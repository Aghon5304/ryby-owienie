using Godot;
using System;

public partial class Player : Node
{
	[Export]
	public int Speed { get; set; } = 40; // How fast the player will move (pixels/sec).

	[Export]
	public int FallAcceleration { get; set; } = 10; // How fast the player will fall (pixels/sec^2).
}
