using System.Numerics;
using OpenTabletDriver.Plugin.Platform.Display;
using OpenTabletDriver.Plugin.Platform.Pointer;
using OpenTabletDriver.Plugin.Tablet;

namespace VoiDPlugins.OutputMode
{
    public class DummyAbsolutePointer : IAbsolutePointer
    {
        public DummyAbsolutePointer()
        {
        }

        public void SetPosition(Vector2 pos)
        {
        }
    }

    public class DummyRelativePointer : IRelativePointer
    {
        public DummyRelativePointer()
        {
        }

        public void SetPosition(Vector2 pos)
        {
        }
    }
}