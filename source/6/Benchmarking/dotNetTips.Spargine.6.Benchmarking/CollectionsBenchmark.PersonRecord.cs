// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-19-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.PersonRecord.cs" company="David McCarter - dotNetTips.com">
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
	/// The person record reference array
	/// </summary>
	private PersonRecord[] _personRecordArray;

	/// <summary>
	/// The person record reference array half
	/// </summary>
	private PersonRecord[] _personRecordArrayHalf;

	/// <summary>
	/// The person record list
	/// </summary>
	private List<PersonRecord> _personRecordList;

	/// <summary>
	/// The person record reference array half
	/// </summary>
	private List<PersonRecord> _personRecordListHalf;

	/// <summary>
	/// Loads the person record array.
	/// </summary>
	protected void LoadPersonRecordCollections()
	{
		this._personRecordListHalf = RandomData.GeneratePersonRecordCollection(this.MaxCount / 2).ToList();
		this._personRecordList = RandomData.GeneratePersonRecordCollection(this.MaxCount).ToList();
		this._personRecordArrayHalf = RandomData.GeneratePersonRecordCollection(this.MaxCount / 2).ToArray();
		this._personRecordArray = RandomData.GeneratePersonRecordCollection(this.MaxCount).ToArray();
	}

	/// <summary>
	/// Gets <see cref="PersonRecord" /> array.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>PersonProper[].</returns>
	public PersonRecord[] GetPersonRecordArray(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personRecordArray.Clone<PersonRecord[]>()
			: this._personRecordArrayHalf.Clone<PersonRecord[]>();
	}

	/// <summary>
	/// Gets the person record list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>List&lt;PersonRecord&gt;.</returns>
	public List<PersonRecord> GetPersonRecordList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personRecordList.Clone<List<PersonRecord>>()
			: this._personRecordListHalf.Clone<List<PersonRecord>>();
	}

}