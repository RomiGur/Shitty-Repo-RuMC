using Content.Client.Viewport;
using Robust.Shared.GameObjects;
using Robust.Shared.Graphics;

namespace Content.Client._RuMC14.Eye;

public static class RuMCViewportEyeExtensions
{
    /// <summary>Whether the viewport shows the player's view, including the Z-level base pass.</summary>
    public static bool IsPlayerView(this IEye? viewportEye, EyeComponent playerEye)
    {
        return ReferenceEquals(viewportEye, playerEye.Eye) ||
               viewportEye is ScalingViewport.ZEye { Depth: 0 };
    }
}
