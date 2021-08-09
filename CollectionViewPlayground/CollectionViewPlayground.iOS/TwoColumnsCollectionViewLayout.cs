using System.Collections.Generic;
using System.Linq;
using CoreGraphics;
using Foundation;
using UIKit;

namespace CollectionViewPlayground.iOS
{
    public class TwoColumnsCollectionViewLayout : UICollectionViewLayout
    {
        public TwoColumnsCollectionViewLayout() : base()
        {
  
        }
        public TwoColumnsLayoutDelegate Delegate { get; set; }

        private int _numOfColumns = 2;

        private float contentHeight = 0;

        private List<UICollectionViewLayoutAttributes> _cache =
            new List<UICollectionViewLayoutAttributes>();
        private float contentWidth
        {
            get
            {
                var bounds = CollectionView.Bounds;
                var insets = CollectionView.ContentInset;
                return (float)(bounds.Width - insets.Left - insets.Right);
            }
        }

        public override CGSize CollectionViewContentSize => new CGSize(contentWidth, contentHeight);

        private System.nint _numOfSection => CollectionView.NumberOfSections();

        private System.nint numOfItemsInSection(int section)
        {
            return CollectionView.NumberOfItemsInSection(section);
        }

        public override void InvalidateLayout()
        {
            _cache.Clear();
            contentHeight = 0;
            
            base.InvalidateLayout();
        }

        public override void PrepareLayout()
        {
            var columnWidth = contentWidth / _numOfColumns;
        
            var xOffsets = new List<float>();
            var yOffsets = new List<float>();
            
         
            var sections = _numOfSection;
            var itemsCount = numOfItemsInSection(0);
            for (int i = 0; i < itemsCount; i++)
            {
                var column = i % _numOfColumns;
                xOffsets.Add(column*columnWidth);
            }

            for (int i = 0; i < _numOfColumns; i++)
            {
                
                yOffsets.Add(0);
            }

            for (int i = 0; i < itemsCount; i++)
            {
                var indexPath = NSIndexPath.FromItemSection(i, 0);
                var column = i % _numOfColumns; 
                var height = Delegate?.GetHeight(CollectionView, indexPath, columnWidth) ?? 0;
                var frame = new CGRect(xOffsets[i],
                    yOffsets[column],
                    columnWidth,
                    height
                );
   

                var attrib = TwoColumnsCOllectionViewLayoutAttributes.CreateForCell(indexPath);
                attrib.Frame = frame;

                yOffsets[column] += height;
                _cache.Add(attrib);
                var max = yOffsets.Max(x => x);
                contentHeight = max;
            }
            
        }

        public override UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect(CGRect rect)
        {
            var attrs = new List<UICollectionViewLayoutAttributes>();

            foreach (var attrib in _cache)
            {
                if (attrib.Frame.IntersectsWith(rect))
                {
                    attrs.Add(attrib);
                }
            }

            return attrs.ToArray();
        }
    }
}