using System.Collections.Generic;
using Avalonia.Input;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    /// <summary>
    /// Holds information about an automatic row drag/drop operation carried out
    /// by <see cref="Avalonia.Controls.TreeDataGrid.AutoDragDropRows"/>.
    /// </summary>
    public class DragInfo
    {
        /// <summary>
        /// Defines the data format used in an <see cref="IDataTransfer"/> for
        /// automatic row drag/drop operations.
        /// </summary>
        /// <remarks>
        /// The format is in-process only because <see cref="DragInfo"/> holds a
        /// reference to the source and is never serialized to the platform
        /// clipboard or a cross-process drag/drop payload.
        /// </remarks>
        public static readonly DataFormat<DragInfo> DataFormat =
            Avalonia.Input.DataFormat.CreateInProcessFormat<DragInfo>("TreeDataGridDragInfo");

        /// <summary>
        /// Initializes a new instance of the <see cref="DragInfo"/> class.
        /// </summary>
        /// <param name="source">The source of the drag operation/</param>
        /// <param name="indexes">The indexes being dragged.</param>
        public DragInfo(ITreeDataGridSource source, IEnumerable<IndexPath> indexes)
        {
            Source = source;
            Indexes = indexes;
        }

        /// <summary>
        /// Gets the <see cref="ITreeDataGridSource"/> that rows are being dragged from.
        /// </summary>
        public ITreeDataGridSource Source { get; }

        /// <summary>
        /// Gets or sets the model indexes of the rows being dragged.
        /// </summary>
        public IEnumerable<IndexPath> Indexes { get; }
    }
}
