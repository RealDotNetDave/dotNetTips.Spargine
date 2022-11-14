// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : David McCarter
// Created          : 01-19-2019
//
// Last Modified By : David McCarter
// Last Modified On : 11-09-2022
// ***********************************************************************
// <copyright file="RandomData.cs" company="dotNetTips.Spargine.6.Tester">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Methods to randomly generate data for unit and benchmark testing.</summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using DotNetTips.Spargine.Tester.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Methods to randomly generate data for unit and benchmark testing.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public static class RandomData
{
	/// <summary>
	/// The default file extension
	/// </summary>
	private const string DefaultFileExtension = "dotnettips.temp";

	/// <summary>
	/// The default file length
	/// </summary>
	private const int DefaultFileLength = 1024;

	/// <summary>
	/// The maximum file byte length
	/// </summary>
	private const int FileByteLengthChunk = 1024;

	/// <summary>
	/// The default maximum character for creating words.
	/// </summary>
	public const char DefaultMaxCharacter = 'z';

	/// <summary>
	/// The default maximum character random file name.
	/// </summary>
	public const char DefaultMaxCharacterRandomFile = 'Z';

	/// <summary>
	/// The default minimum character for creating words.
	/// </summary>
	public const char DefaultMinCharacter = 'A';

	/// <summary>
	/// The default minimum character random file name.
	/// </summary>
	public const char DefaultMinCharacterRandomFile = 'A';

	/// <summary>
	/// The domain extensions used to create random Urls.
	/// </summary>
	private static readonly string[] _domainExtensions = new string[] { ".com", ".co.uk", ".org", ".org.uk", ".net", ".us", ".com.au", ".es", ".fr", ".de", ".ly", ".gov", ".gov.uk", ".ac.uk", ".website", ".store", ".health", ".band", ".spargine.com", ".rock", ".dotnettips" };

	/// <summary>
	/// The synchronize lock
	/// </summary>
	private static readonly object _lock = new();

	/// <summary>
	/// The random number generator
	/// </summary>
	[ThreadStatic]
	private static readonly RandomNumberGenerator _randomNumberGenerator;

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Initializes static members of the <see cref="RandomData" /> class.
	/// </summary>
	static RandomData()
	{
		_randomNumberGenerator = RandomNumberGenerator.Create();
	}

	/// <summary>
	/// Picks a random string from an array.
	/// </summary>
	/// <param name="words">The words.</param>
	/// <returns>System.String.</returns>
	private static string Of(params string[] words) => words[GenerateInteger(0, words.Length - 1)];

	/// <summary>
	/// Chunks the number.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="chunkSize">Size of the chunk.</param>
	/// <returns>IEnumerable&lt;System.Int32&gt;.</returns>
	internal static IEnumerable<int> ChunkNumber(this int input, int chunkSize)
	{
		for (var chunkIndex = 0; chunkIndex < input; chunkIndex += chunkSize)
		{
			yield return Math.Min(chunkSize, input - chunkIndex);
		}
	}

	/// <summary>
	/// Creates the file.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="fileLength">Length of the file.</param>
	internal static void CreateFile(string fileName, int fileLength = DefaultFileLength)
	{
		var chars = new ReadOnlySpan<char>(GenerateWord(fileLength).ToCharArray());

		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}

		var sliceStart = 0;

		using (var stream = File.AppendText(fileName))
		{
			foreach (var size in fileLength.ChunkNumber(FileByteLengthChunk))
			{
				stream.Write(chars.Slice(sliceStart, size));
				sliceStart += size;
			}

			stream.Flush();
		}
	}

	/// <summary>
	/// Generates <see cref="AddressRecord" />s.
	/// </summary>
	/// <param name="count">The number of items to create. Default value = 2. Valid values are from 1 - 100.</param>
	/// <param name="addressLength">Length of the address.</param>
	/// <param name="cityLength">Length of the city.</param>
	/// <param name="countryLength">Length of the country.</param>
	/// <param name="countyProvinceLength">Length of the county province.</param>
	/// <param name="postalCodeLength">Length of the postal code.</param>
	/// <param name="stateLength">Length of the state.</param>
	/// <returns>IAddressRecord[].</returns>
	[Information(nameof(GenerateAddressRecordCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static Collection<AddressRecord> GenerateAddressRecordCollection(int count = 2, int addressLength = 25, int cityLength = 25, int countryLength = 25, int countyProvinceLength = 20, int postalCodeLength = 8, int stateLength = 15)
	{
		count = count.ArgumentInRange(lower: 1, upper: 100, defaultValue: 2);

		var addresses = new List<AddressRecord>(count);

		for (var addressIndex = 0; addressIndex < count; addressIndex++)
		{
			AddressRecord address = new(GenerateKey())
			{
				Address1 = GenerateWord(addressLength),
				Address2 = GenerateWord(addressLength),
				City = GenerateWord(cityLength),
				Country = GenerateWord(countryLength),
				CountyProvince = GenerateWord(countyProvinceLength),
				Phone = GeneratePhoneNumberUSA(),
				PostalCode = GenerateNumber(postalCodeLength),
				State = GenerateWord(stateLength),
			};

			addresses.Add(address);
		}

		addresses.TrimExcess();

		return new Collection<AddressRecord>(addresses);
	}

	/// <summary>
	/// Generates a <see cref="byte" /> array.
	/// </summary>
	/// <param name="sizeInKb">The size in kb. Size must be <see cref="double.Epsilon" /> or greater.</param>
	/// <returns>System.Byte[].</returns>
	/// <remarks>Uses RandomNumberGenerator due to performance increase [CA5394]. Uses Span.</remarks>
	[Information(nameof(GenerateByteArray), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Updated)]
	public static byte[] GenerateByteArray(double sizeInKb)
	{
		sizeInKb = sizeInKb.ArgumentMeetsCondition(sizeInKb >= double.Epsilon, errorMessage: string.Format(CultureInfo.InvariantCulture, Resources.SizeMustBeEpsilon, double.Epsilon));

		var bytes = new Span<byte>(new byte[Convert.ToInt32(sizeInKb * 1024)]);

		lock (_lock)
		{
			_randomNumberGenerator.GetBytes(bytes);
		}

		return bytes.ToArray();
	}

	/// <summary>
	/// Creates a random character.
	/// </summary>
	/// <returns>System.Char.</returns>
	/// <example>Output: 82 'R'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static char GenerateCharacter()
	{
		return GenerateCharacter(DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Creates a random <see cref="char" />.
	/// </summary>
	/// <param name="minValue">The minimum character value.</param>
	/// <param name="maxValue">The maximum character value.</param>
	/// <returns>System.Char.</returns>
	/// <example>Output: 65 'A'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static char GenerateCharacter(char minValue, char maxValue)
	{
		return (char)GenerateInteger(minValue, maxValue);
	}

	/// <summary>
	/// Creates a <see cref="ICoordinate" /> object with random values.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <returns>T.</returns>
	/// <example>Output: X: 178765551 Y: -2145952440</example>
	[Information(nameof(GenerateCoordinate), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static T GenerateCoordinate<T>() where T : ICoordinate, new()
	{
		return new T
		{
			X = GenerateInteger(),
			Y = GenerateInteger()
		};
	}

	/// <summary>
	/// Creates collection of  <see cref="ICoordinate" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="count">The number of items to create. Minimum value is 1.</param>
	/// <returns>List&lt;T&gt;.</returns>
	/// <example>Output: [0]: {2089369587--284215139} [1]: {244137335-1577361939}</example>
	[Information(nameof(GenerateCoordinateCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static IEnumerable<T> GenerateCoordinateCollection<T>(int count) where T : ICoordinate, new()
	{
		count = count.ArgumentInRange(lower: 1);

		var coordinates = new List<T>(count);

		for (var coordinateIndex = 0; coordinateIndex < count; coordinateIndex++)
		{
			coordinates.Add(GenerateCoordinate<T>());
		}

		coordinates.TrimExcess();

		return coordinates;
	}

	/// <summary>
	/// Creates a random <see cref="decimal" /> value.
	/// </summary>
	/// <param name="minValue">The minimum value.</param>
	/// <param name="maxValue">The maximum value.</param>
	/// <param name="decimalPlaces">The decimal places. Minimum value = 0.</param>
	/// <returns>System.Decimal.</returns>
	/// <example>Output: 95.15</example>
	[Information(nameof(GenerateDecimal), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static decimal GenerateDecimal(decimal minValue, decimal maxValue, int decimalPlaces)
	{
		decimalPlaces = decimalPlaces.ArgumentInRange(lower: 0);

		var multiplier = ((decimal)decimalPlaces) * 10;

		return GenerateInteger((int)(minValue * multiplier), (int)(maxValue * multiplier)) / multiplier;
	}

	/// <summary>
	/// Returns a random domain extension.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: ".co.uk"</example>
	[Information(nameof(GenerateDomainExtension), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateDomainExtension()
	{
		return Of(_domainExtensions);
	}

	/// <summary>
	/// Creates a random email address.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: fbxpfvtanqysqmuqfh@kiuvf.fr</example>
	[Information(nameof(GenerateEmailAddress), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateEmailAddress()
	{
		return $"{GenerateWord(5, 25, 'a', 'z')}@{GenerateWord(5, 25, 'a', 'z')}{GenerateDomainExtension()}";
	}

	/// <summary>
	/// Generates the a test file.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="fileLength">Byte length of the file. Minimum length = 1</param>
	/// <returns>Name of the file generated.</returns>
	/// <example>Output: c:\\temp\\UnitTest.test</example>
	[Information(nameof(GenerateFile), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateFile(string fileName, int fileLength = DefaultFileLength)
	{
		fileName = fileName.ArgumentNotNullOrEmpty(trim: true);
		fileLength = fileLength.ArgumentInRange(lower: 1);

		CreateFile(fileName, fileLength);

		return fileName;
	}

	/// <summary>
	/// Generates random files in temporary path.
	/// </summary>
	/// <param name="count">The number of files to create. Minimum value = 1.</param>
	/// <param name="fileLength">Length of the file. Minimum value = 1.</param>
	/// <param name="fileExtension">The file extension.</param>
	/// <returns>System.ValueTuple&lt;System.String, IEnumerable&lt;System.String&gt;&gt;.</returns>
	/// <example>Output: Path: "C:\\Users\\dotNetDave\\AppData\\Local\\Temp\\" Files: Count = 100</example>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static (string Path, IEnumerable<string> Files) GenerateFiles(int count = 100, int fileLength = DefaultFileLength, string fileExtension = DefaultFileExtension)
	{
		count = count.ArgumentInRange(lower: 1);
		fileLength = fileLength.ArgumentInRange(lower: 1);
		fileExtension = fileExtension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var files = new List<string>(count);

		for (var fileIndex = 0; fileIndex < count; fileIndex++)
		{
			files.Add(GenerateFile(GenerateRandomFileName(fileNameLength: 25, extension: fileExtension), fileLength));
		}

		files.TrimExcess();

		return (Path.GetTempPath(), files.AsEnumerable());
	}

	/// <summary>
	/// Generates random files.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="count">The number of files to create. Minimum value = 1.</param>
	/// <param name="fileLength">Length of the file. Minimum value = 1.</param>
	/// <returns>Collection of file names that were created.</returns>
	/// <example>Output: [0]: "c:\\temp\\dobybcyx.lj"  [1]: "c:\\temp\\zo2ggwub.3ro"</example>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static IEnumerable<string> GenerateFiles(string path, int count = 100, int fileLength = DefaultFileLength)
	{
		path = path.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(lower: 1);
		fileLength = fileLength.ArgumentInRange(lower: 1);

		_ = Directory.CreateDirectory(path);

		var files = new List<string>(count);

		for (var fileCount = 0; fileCount < count; fileCount++)
		{
			var fileName = GenerateRandomFileName(path);

			CreateFile(fileName, fileLength);

			files.Add(fileName);
		}

		files.TrimExcess();

		return files;
	}

	/// <summary>
	/// Creates a random <see cref="int" /> value.
	/// </summary>
	/// <param name="min">The minimum int.</param>
	/// <param name="max">The maximum int.</param>
	/// <returns>System.Int32.</returns>
	/// <remarks>Does not use RandomNumberGenerator due to performance increase. [CA5394]</remarks>
	[Information(nameof(GenerateInteger), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static int GenerateInteger(int min = int.MinValue, int max = int.MaxValue)
	{
		//Ensure maxLength is +1 of minLength so the RandomNumberGenerator does not cause an exception.
		min = min.EnsureMinimum(1);
		max = max.EnsureMinimum(min + 1);

		lock (_lock)
		{
			return RandomNumberGenerator.GetInt32(min, max);
		}
	}

	/// <summary>
	/// Creates a random key from a GUID.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "1/19/2019", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateKey()
	{
		return KeyGenerator.GenerateKey();
	}

	/// <summary>
	/// Creates a random number.
	/// </summary>
	/// <param name="length">The length of the number. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: "446085072052112"</example>
	/// <remarks>Does not use RandomNumberGenerator due to performance increase. [CA5394]</remarks>
	[Information(nameof(GenerateNumber), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateNumber(int length)
	{
		length = length.ArgumentInRange(lower: 1);

		var sb = _stringBuilderPool.Get();

		try
		{
			lock (_lock)
			{
				for (var numberIndex = 0; numberIndex < length; numberIndex++)
				{
					_ = sb.Append(RandomNumberGenerator.GetInt32(0, 9));
				}
			}

			return sb.ToString().ToTrimmed();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generates a <see cref="PersonRecord" /> collection.
	/// </summary>
	/// <param name="count">The number of items to create. Minimum value = 1.</param>
	/// <param name="addressCount">The address count.</param>
	/// <param name="firstNameLength">First length of the name.</param>
	/// <param name="lastNameLength">Last length of the name.</param>
	/// <param name="addressLength">Length of the address.</param>
	/// <param name="cityLength">Length of the city.</param>
	/// <param name="countryLength">Length of the country.</param>
	/// <param name="countyProvinceLength">Length of the county province.</param>
	/// <param name="postalCodeLength">Length of the postal code.</param>
	/// <param name="stateLength">Length of the state.</param>
	/// <returns>IPersonRecord[].</returns>
	[Information(nameof(GeneratePersonRecordCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static Collection<PersonRecord> GeneratePersonRecordCollection(int count, int addressCount = 2, int firstNameLength = 15, int lastNameLength = 25, int addressLength = 25, int cityLength = 25, int countryLength = 25, int countyProvinceLength = 20, int postalCodeLength = 8, int stateLength = 15)
	{
		count = count.ArgumentInRange(lower: 1);

		var records = new Collection<PersonRecord>();

		for (var recordIndex = 0; recordIndex < count; recordIndex++)
		{
			PersonRecord person = new(email: GenerateEmailAddress(), id: GenerateKey())
			{
				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
				FirstName = GenerateWord(firstNameLength),
				HomePhone = GeneratePhoneNumberUSA(),
				LastName = GenerateWord(lastNameLength),
				CellPhone = GeneratePhoneNumberUSA(),
				Addresses = GenerateAddressRecordCollection(addressCount, addressLength, cityLength, countryLength, countyProvinceLength, postalCodeLength, stateLength),
			};

			records.Add(person);
		}

		return records;
	}

	/// <summary>
	/// Generates a <see cref="IPerson" /> reference collection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="count">The number of items to create. Minimum value = 1.</param>
	/// <returns>T[].</returns>
	[Information(nameof(GeneratePersonRefCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static Collection<T> GeneratePersonRefCollection<T>(int count) where T : IPerson, new()
	{
		count = count.ArgumentInRange(lower: 1);

		var people = new Collection<T>();

		for (var index = 0; index < count; index++)
		{
			people.Add(GenerateRefPerson<T>());
		}

		return people;
	}

	/// <summary>
	/// Generates a <see cref="Models.ValueTypes.Person" /> value collection.
	/// </summary>
	/// <param name="count">The count.</param>
	/// <returns>Collection&lt;Models.ValueTypes.Person&gt;.</returns>
	[Information(nameof(GeneratePersonValCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static Collection<Models.ValueTypes.Person> GeneratePersonValCollection(int count)
	{
		count = count.ArgumentInRange(lower: 1);

		var people = new Collection<Models.ValueTypes.Person>();

		for (var index = 0; index < count; index++)
		{
			people.Add(GenerateValPerson());
		}

		return people;
	}

	/// <summary>
	/// Creates a US phone number.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: 284-424-2216</example>
	[Information(nameof(GeneratePhoneNumberUSA), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GeneratePhoneNumberUSA()
	{
		return $"{GenerateNumber(3)}-{GenerateNumber(3)}-{GenerateNumber(4)}";
	}

	/// <summary>
	/// Generates random file name.
	/// </summary>
	/// <param name="fileNameLength">Length of the file name. Minimum value = 1. Maximim value = 256.</param>
	/// <param name="extension">The extension.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: C:\\Users\\dotNetDave\\AppData\\Local\\Temp\\FOGWYNDRBM.dotnettips</example>
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateRandomFileName(int fileNameLength = 10, string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(1, upper: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{ControlChars.Dot}{extension}";

		return Path.Combine(Path.GetTempPath(), fileName);
	}

	/// <summary>
	/// Generates a random file name.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="fileNameLength">Length of the file name. Minimum value = 1. Maximum value = 256.</param>
	/// <param name="extension">The extension.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: c:\\temp\\FFDHRBMDXP.dotnettips</example>
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateRandomFileName([NotNull] string path, int fileNameLength = 10, string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(1, upper: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{ControlChars.Dot}{extension}";

		return Path.Combine(path, fileName);
	}

	/// <summary>
	/// Generates a <see cref="IPerson" /> reference type with default values.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="addressLength">Length of the address.</param>
	/// <param name="cityLength">Length of the city.</param>
	/// <param name="countryLength">Length of the country.</param>
	/// <param name="firstNameLength">First length of the name.</param>
	/// <param name="lastNameLength">Last length of the name.</param>
	/// <param name="postalCodeLength">Length of the postal code.</param>
	/// <param name="stateLength">Length of the state.</param>
	/// <returns>T.</returns>
	[Information(nameof(GenerateRefPerson), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static T GenerateRefPerson<T>(int addressLength = 25, int cityLength = 15, int countryLength = 15, int firstNameLength = 15, int lastNameLength = 25, int postalCodeLength = 8, int stateLength = 15) where T : IPerson, new()
	{
		var person = new T
		{
			Id = GenerateKey(),
			Address1 = GenerateWord(addressLength),
			Address2 = GenerateWord(addressLength),
			BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
			CellPhone = GeneratePhoneNumberUSA(),
			City = GenerateWord(cityLength),
			Country = GenerateWord(countryLength),
			Email = GenerateEmailAddress(),
			FirstName = GenerateWord(firstNameLength),
			HomePhone = GeneratePhoneNumberUSA(),
			LastName = GenerateWord(lastNameLength),
			PostalCode = GenerateNumber(postalCodeLength),
			State = GenerateWord(stateLength)
		};

		return person;
	}

	/// <summary>
	/// Creates a random relative url.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output:"/ljsylu/rsglcurkiylqld/wejdbuainlgjofnv/uwbrjftyt/"</example>
	[Information(nameof(GenerateRelativeUrl), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateRelativeUrl()
	{
		var sb = _stringBuilderPool.Get();

		try
		{
			for (var lengthIndex = 0; lengthIndex < GenerateInteger(1, 10); lengthIndex++)
			{
				_ = sb.Append(GenerateUrlPart());
			}

			sb = sb.Append('/');

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generates a random file.
	/// </summary>
	/// <param name="fileLength">The length. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: C:\\Users\\dotNetDave\\AppData\\Local\\Temp\\klxpckpo.24h</example>
	[Information(nameof(GenerateTempFile), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateTempFile(int fileLength = DefaultFileLength)
	{
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: DefaultFileLength);

		var fileName = GenerateRandomFileName();
		var fakeText = GenerateWord(fileLength);

		File.WriteAllText(fileName, fakeText);

		return fileName;
	}

	/// <summary>
	/// Creates a random Url.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: https://www.agngbgluhawxhnmoxvdogla.hdtmdjmiagwlx.com/r/ulhekwhqnicq/bxxmyq/owaqaqxvdvtae/</example>
	[Information(nameof(GenerateUrl), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateUrl()
	{
		return $"{GenerateUrlHostName()}{GenerateRelativeUrl()}";
	}

	/// <summary>
	/// Creates a random url host name.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: https://www.ehvjnbhcpcivgiccugim.lfa.net</example>
	[Information(nameof(GenerateUrlHostName), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateUrlHostName()
	{
		return $"https://{GenerateUrlHostNameNoProtocol()}";
	}

	/// <summary>
	/// Creates a url without a protocol.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: www.wucqcapnybi.kejdwudpbstekhxic.co.uk</example>
	[Information(nameof(GenerateUrlHostNameNoProtocol), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateUrlHostNameNoProtocol()
	{
		return $"www.{GenerateWord(1, 25, 'a', 'z')}.{GenerateUrlHostNameNoSubDomain()}";
	}

	/// <summary>
	/// Creates host name without a sub domain.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: elqqcw.org.uk</example>
	[Information(nameof(GenerateUrlHostNameNoSubDomain), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateUrlHostNameNoSubDomain()
	{
		return $"{GenerateWord(3, 25, 'a', 'z')}{GenerateDomainExtension()}";
	}

	/// <summary>
	/// Create a random url part.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <remarks>/rregyyjxpjiats</remarks>
	[Information(nameof(GenerateUrlPart), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateUrlPart()
	{
		return $"/{GenerateWord(1, 25, 'a', 'z')}";
	}

	/// <summary>
	/// Generates a <see cref="Models.ValueTypes.Person" /> with default values.
	/// </summary>
	/// <param name="addressLength">Length of the address.</param>
	/// <param name="cityLength">Length of the city.</param>
	/// <param name="countryLength">Length of the country.</param>
	/// <param name="firstNameLength">First length of the name.</param>
	/// <param name="lastNameLength">Last length of the name.</param>
	/// <param name="postalCodeLength">Length of the postal code.</param>
	/// <param name="stateLength">Length of the state.</param>
	/// <returns>Models.ValueTypes.Person.</returns>
	[Information(nameof(GenerateRefPerson), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static Models.ValueTypes.Person GenerateValPerson(int addressLength = 25, int cityLength = 15, int countryLength = 15, int firstNameLength = 15, int lastNameLength = 25, int postalCodeLength = 8, int stateLength = 15)
	{
		var person = new Models.ValueTypes.Person
		{
			Id = GenerateKey(),
			Address1 = GenerateWord(addressLength),
			Address2 = GenerateWord(addressLength),
			BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
			CellPhone = GeneratePhoneNumberUSA(),
			City = GenerateWord(cityLength),
			Country = GenerateWord(countryLength),
			Email = GenerateEmailAddress(),
			FirstName = GenerateWord(firstNameLength),
			HomePhone = GeneratePhoneNumberUSA(),
			LastName = GenerateWord(lastNameLength),
			PostalCode = GenerateNumber(postalCodeLength),
			State = GenerateWord(stateLength)
		};

		return person;
	}

	/// <summary>
	/// Creates a random word.
	/// </summary>
	/// <param name="length">The length. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: mL_g[E_E_CsoJvjshI]CFjFKa</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int length)
	{
		length = length.ArgumentInRange(lower: 1);

		var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);

		return returnValue;
	}

	/// <summary>
	/// Creates a random word.
	/// </summary>
	/// <param name="minLength">The minimum length. Minimum value = 1.</param>
	/// <param name="maxLength">The maximum length. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: oMOYxlFvqclVQK</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int minLength, int maxLength)
	{
		minLength = minLength.ArgumentInRange(lower: 1);
		maxLength = maxLength.ArgumentInRange(lower: 1);

		return GenerateWord(minLength, maxLength, DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Creates a random word.
	/// </summary>
	/// <param name="length">The length. Minimum value = 1.</param>
	/// <param name="minCharacter">The minimum character.</param>
	/// <param name="maxCharacter">The maximum character.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: LBEEUMHHHK</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int length, char minCharacter, char maxCharacter)
	{
		length = length.ArgumentInRange(lower: 1);

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var wordIndex = 0; wordIndex < length; wordIndex++)
			{
				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Creates a random word.
	/// </summary>
	/// <param name="minLength">The minimum length.</param>
	/// <param name="maxLength">The maximum length.</param>
	/// <param name="minCharacter">The minimum character.</param>
	/// <param name="maxCharacter">The maximum character.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: ACRNFTPAE</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int minLength, int maxLength, char minCharacter, char maxCharacter)
	{
		minLength = minLength.ArgumentInRange(1);
		maxLength = maxLength.ArgumentInRange(1);

		return GenerateWord(GenerateInteger(minLength, maxLength), minCharacter, maxCharacter);
	}

	/// <summary>
	/// Generates a list of words.
	/// </summary>
	/// <param name="count">The word count. Minimum value = 1.</param>
	/// <param name="minLength">The minimum length. Minimum value = 1.</param>
	/// <param name="maxLength">The maximum length. Minimum value = 1.</param>
	/// <returns>ImmutableList&lt;System.String&gt;.</returns>
	/// <example>
	/// Output:
	/// [0]: "oKcMYETNvpiByRQVa^"
	/// [1]: "mnM\\wQwuluQ^VFxpOJEgLX"
	/// [2]: "Ad\\kCOMkmdK"
	/// </example>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static ImmutableList<string> GenerateWords(int count, int minLength, int maxLength)
	{
		count = count.ArgumentInRange(lower: 1);
		minLength = minLength.ArgumentInRange(lower: 1);
		maxLength = maxLength.ArgumentInRange(lower: 1);

		var strings = new List<string>(count);

		for (var wordCount = 0; wordCount < count; wordCount++)
		{
			strings.Add(GenerateWord(minLength, maxLength));
		}

		strings.TrimExcess();

		return strings.ToImmutableList();
	}

	/// <summary>
	/// Gets the long test string.
	/// </summary>
	/// <value>The long test string.</value>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string LongTestString => Resources.LongTestString;
}
