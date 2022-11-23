using System;
using SkiaSharp;

#pragma warning disable 1591

namespace CondenseTech.Pdfium
{
    public struct PdfRectangle : IEquatable<PdfRectangle>
    {
        public static readonly PdfRectangle Empty = new PdfRectangle();

        // _page is offset by 1 so that Empty returns an invalid rectangle.
        private readonly int _page;

        public int Page
        {
            get { return _page - 1; }
        }

        public SKRect Bounds { get; }

        public bool IsValid
        {
            get { return _page != 0; }
        }

        public PdfRectangle(int page, SKRect bounds)
        {
            _page = page + 1;
            Bounds = bounds;
        }

        public bool Equals(PdfRectangle other)
        {
            return
                Page == other.Page &&
                Bounds == other.Bounds;
        }

        public override bool Equals(object obj)
        {
            return
                obj is PdfRectangle &&
                Equals((PdfRectangle)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Page * 397) ^ Bounds.GetHashCode();
            }
        }

        public static bool operator ==(PdfRectangle left, PdfRectangle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PdfRectangle left, PdfRectangle right)
        {
            return !left.Equals(right);
        }
    }
}
