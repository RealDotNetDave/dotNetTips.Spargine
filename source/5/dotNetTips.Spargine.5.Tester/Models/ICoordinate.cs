
namespace dotNetTips.Spargine.Tester.Models
{
    /// <summary>
    /// Interface ICoordinate used to create Coordinate.
    /// </summary>
    public interface ICoordinate
    {
        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>
        /// <value>The x value.</value>
        int X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>
        /// <value>The y value.</value>
        int Y { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> of the coordinates.
        /// </summary>
        /// <returns>A <see cref="System.String" /> of the coordinates.</returns>
        string ToString();

    }
}
