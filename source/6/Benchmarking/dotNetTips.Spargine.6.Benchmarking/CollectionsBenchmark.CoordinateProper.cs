// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-20-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.CoordinateProper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************


//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Partial class for Collections benchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public partial class CollectionsBenchmark
{

	/// <summary>
	/// The coordinate proper array
	/// </summary>
	private CoordinateProper[] _coordinateProperArray;

	/// <summary>
	/// The coordinate proper array half
	/// </summary>
	private CoordinateProper[] _coordinateProperArrayHalf;

	/// <summary>
	/// The coordinate proper list
	/// </summary>
	private List<CoordinateProper> _coordinateProperList;

	/// <summary>
	/// The coordinate proper list half
	/// </summary>
	private List<CoordinateProper> _coordinateProperListHalf;


	/// <summary>
	/// Loads the coordinate array.
	/// </summary>
	protected void LoadCoordinateProperCollections()
	{
		this._coordinateProperListHalf = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.MaxCount / 2).ToList();
		this._coordinateProperList = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.MaxCount).ToList();
		this._coordinateProperArrayHalf = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.MaxCount / 2).ToArray();
		this._coordinateProperArray = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.MaxCount).ToArray();
	}

	/// <summary>
	/// Gets <see cref="CoordinateProper" /> array.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>CoordinateProper[].</returns>
	public CoordinateProper[] GetCoordinateProperValArray(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._coordinateProperArray.Clone<CoordinateProper[]>()
			: this._coordinateProperArrayHalf.Clone<CoordinateProper[]>();
	}

	/// <summary>
	/// Gets the coordinate proper list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>CoordinateProper[].</returns>
	public List<CoordinateProper> GetCoordinateProperValList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._coordinateProperArray.Clone<CoordinateProper[]>().ToList()
			: this._coordinateProperArrayHalf.Clone<CoordinateProper[]>().ToList();
	}

}
