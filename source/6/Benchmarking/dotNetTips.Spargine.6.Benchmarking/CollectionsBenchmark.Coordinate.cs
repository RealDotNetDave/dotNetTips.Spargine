// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;

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
	/// The coordinate array
	/// </summary>
	private Tester.Models.ValueTypes.Coordinate[] _coordinateArray;

	/// <summary>
	/// The coordinate array half
	/// </summary>
	private Tester.Models.ValueTypes.Coordinate[] _coordinateArrayHalf;

	/// <summary>
	/// The coordinate list
	/// </summary>
	private List<Tester.Models.ValueTypes.Coordinate> _coordinateList;

	/// <summary>
	/// The coordinate list half
	/// </summary>
	private List<Tester.Models.ValueTypes.Coordinate> _coordinateListHalf;

	/// <summary>
	/// Loads the coordinate array.
	/// </summary>
	protected void LoadCoordinateCollections()
	{
		this._coordinateListHalf = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount / 2).ToList();
		this._coordinateList = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount).ToList();
		this._coordinateArrayHalf = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount / 2).ToArray();
		this._coordinateArray = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount).ToArray();
	}

	/// <summary>
	/// Gets <see cref="Tester.Models.ValueTypes.Coordinate" /> array.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>Tester.Models.ValueTypes.Coordinate[].</returns>
	public Tester.Models.ValueTypes.Coordinate[] GetCoordinateValArray(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._coordinateArray.Clone<Tester.Models.ValueTypes.Coordinate[]>()
			: this._coordinateArrayHalf.Clone<Tester.Models.ValueTypes.Coordinate[]>();
	}

	/// <summary>
	/// Gets the coordinate list.
	/// </summary>
	/// <param name="collectionSize">Size of the collection.</param>
	/// <returns>Tester.Models.ValueTypes.Coordinate[].</returns>
	public Tester.Models.ValueTypes.Coordinate[] GetCoordinateValList(CollectionSize collectionSize = CollectionSize.Full)
	{
		return collectionSize is CollectionSize.Full
			? this._coordinateArray.Clone<Tester.Models.ValueTypes.Coordinate[]>()
			: this._coordinateArrayHalf.Clone<Tester.Models.ValueTypes.Coordinate[]>();
	}

}
