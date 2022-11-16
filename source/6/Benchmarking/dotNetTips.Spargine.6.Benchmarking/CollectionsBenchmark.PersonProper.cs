// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-26-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.PersonProper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Partial class for Collections benchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public partial class CollectionsBenchmark
{

	/// <summary>
	/// The person proper dictionary
	/// </summary>
	private Dictionary<string, PersonProper> _personProperDictionary;

	/// <summary>
	/// The person proper dictionary half
	/// </summary>
	private Dictionary<string, PersonProper> _personProperDictionaryHalf;

	/// <summary>
	/// The person proper reference array
	/// </summary>
	private PersonProper[] _personProperRefArray;

	/// <summary>
	/// The person proper reference array half
	/// </summary>
	private PersonProper[] _personProperRefArrayHalf;

	/// <summary>
	/// The person proper reference list
	/// </summary>
	private List<PersonProper> _personProperRefList;

	/// <summary>
	/// The person proper reference list half
	/// </summary>
	private List<PersonProper> _personProperRefListHalf;

	/// <summary>
	/// The person proper value list
	/// </summary>
	private List<Tester.Models.ValueTypes.Person> _personProperValList;
	/// <summary>
	/// The person proper value list half
	/// </summary>
	private List<Tester.Models.ValueTypes.Person> _personProperValListHalf;

	/// <summary>
	/// Loads the person proper reference array.
	/// </summary>
	protected void LoadPersonProperCollections()
	{
		this._personProperDictionary = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount).ToDictionary(p => p.Id);
		this._personProperDictionaryHalf = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount / 2).ToDictionary(p => p.Id);
		this._personProperRefArray = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount).ToArray();
		this._personProperRefArrayHalf = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount / 2).ToArray();
		this._personProperRefList = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount).ToList();
		this._personProperRefListHalf = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount / 2).ToList();
		this._personProperValListHalf = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Person>(this.MaxCount / 2).ToList();
		this._personProperValList = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Person>(this.MaxCount).ToList();
	}

	/// <summary>
	/// Gets <see cref="PersonProper" /> array.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>PersonProper[].</returns>
	public PersonProper[] GetPersonProperRefArray(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize == CollectionSize.Full
			? this._personProperRefArray.Clone<PersonProper[]>()
			: this._personProperRefArrayHalf.Clone<PersonProper[]>();
	}

	/// <summary>
	/// Gets <see cref="PersonProper" /> dictionary.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>Dictionary&lt;System.String, PersonProper&gt;.</returns>
	public Dictionary<string, PersonProper> GetPersonProperRefDictionary(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personProperDictionary.Clone<Dictionary<string, PersonProper>>()
			: this._personProperDictionaryHalf.Clone<Dictionary<string, PersonProper>>();
	}

	/// <summary>
	/// Gets the person proper list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>List&lt;PersonProper&gt;.</returns>
	public List<PersonProper> GetPersonProperRefList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize == CollectionSize.Full
			? this._personProperRefList.Clone<List<PersonProper>>()
			: this._personProperRefListHalf.Clone<List<PersonProper>>();
	}

	/// <summary>
	/// Gets the person proper value list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>List&lt;Tester.Models.ValueTypes.Person&gt;.</returns>
	public List<Tester.Models.ValueTypes.Person> GetPersonProperValList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize == CollectionSize.Full
			? this._personProperValList.Clone<List<Tester.Models.ValueTypes.Person>>()
			: this._personProperValListHalf.Clone<List<Tester.Models.ValueTypes.Person>>();
	}
}
