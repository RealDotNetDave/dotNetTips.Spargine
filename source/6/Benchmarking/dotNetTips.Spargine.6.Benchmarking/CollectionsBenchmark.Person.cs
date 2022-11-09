// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.Person.cs" company="David McCarter - dotNetTips.com">
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
	/// The person reference array
	/// </summary>
	private Person[] _personRefArray;

	/// <summary>
	/// The person reference array half
	/// </summary>
	private Person[] _personRefArrayHalf;

	/// <summary>
	/// The person reference list
	/// </summary>
	private List<Person> _personRefList;

	/// <summary>
	/// The person reference array half
	/// </summary>
	private List<Person> _personRefListHalf;

	/// <summary>
	/// The person value array
	/// </summary>
	private Tester.Models.ValueTypes.Person[] _personValArray;

	/// <summary>
	/// The person value array half
	/// </summary>
	private Tester.Models.ValueTypes.Person[] _personValArrayHalf;

	/// <summary>
	/// The person value list
	/// </summary>
	private List<Tester.Models.ValueTypes.Person> _personValList;

	/// <summary>
	/// The person value list half
	/// </summary>
	private List<Tester.Models.ValueTypes.Person> _personValListHalf;

	/// <summary>
	/// Loads the person reference array.
	/// </summary>
	protected void LoadPersonCollections()
	{
		this._personRefArray = RandomData.GeneratePersonRefCollection<Person>(this.MaxCount).ToArray();
		this._personRefArrayHalf = RandomData.GeneratePersonRefCollection<Person>(this.MaxCount / 2).ToArray();
		this._personRefList = RandomData.GeneratePersonRefCollection<Person>(this.MaxCount).ToList();
		this._personRefListHalf = RandomData.GeneratePersonRefCollection<Person>(this.MaxCount / 2).ToList();
		this._personValArray = RandomData.GeneratePersonRefCollection<Tester.Models.ValueTypes.Person>(this.MaxCount).ToArray();
		this._personValArrayHalf = RandomData.GeneratePersonRefCollection<Tester.Models.ValueTypes.Person>(this.MaxCount / 2).ToArray();
		this._personValList = RandomData.GeneratePersonRefCollection<Tester.Models.ValueTypes.Person>(this.MaxCount).ToList();
		this._personValListHalf = RandomData.GeneratePersonRefCollection<Tester.Models.ValueTypes.Person>(this.MaxCount / 2).ToList();
	}

	/// <summary>
	/// Gets <see cref="Person" /> array.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>Person[].</returns>
	public Person[] GetPersonRefArray(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personRefArray.Clone<Person[]>()
			: this._personRefArrayHalf.Clone<Person[]>();
	}

	/// <summary>
	/// Gets the person reference list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>List&lt;Person&gt;.</returns>
	public List<Person> GetPersonRefList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personRefList.Clone<List<Person>>()
			: this._personRefListHalf.Clone<List<Person>>();
	}

	/// <summary>
	/// Gets <see cref="Person" /> array.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>Tester.Models.ValueTypes.Person[].</returns>
	public Tester.Models.ValueTypes.Person[] GetPersonValArray(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personValArray.Clone<Tester.Models.ValueTypes.Person[]>()
			: this._personValArrayHalf.Clone<Tester.Models.ValueTypes.Person[]>();
	}

	/// <summary>
	/// Gets the person value list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>List&lt;Tester.Models.ValueTypes.Person&gt;.</returns>
	public List<Tester.Models.ValueTypes.Person> GetPersonValList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._personValList.Clone<List<Tester.Models.ValueTypes.Person>>()
			: this._personValListHalf.Clone<List<Tester.Models.ValueTypes.Person>>();
	}

}