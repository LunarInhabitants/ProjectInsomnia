# Project Insomnia

A prototype game for the procedural level builder.

## Premise

The game is heavily inspired by Bastion, The Binding of Isaac and 4 play co-op games. Up to four players can join a game, where they will then travel through a number of procedurally generated levels fighting creatures along the way. As they progress, they may find new weapons or character buffs to accomodate for the ever increasing difficulty. Should one player die, they remain as a ghost until they are resurrected at either a resurrection tile at some cost to the other players (Health? Stats?), or the end of the given stage. At the end of each stage, the players must fight a boss before they are allowed to progress. After defeating the boss, they are also granted a large character buff to one stat that they must choose. When all players have chosen, marking themselves as ready, the next stage begins.

In the game lobby, before the game starts, players can choose from a number of characters to play as (Duplicates are allowed). These include:

* The standard character - Average in all stats, can use all weapons
* The melee character - Increased agility, decreased strength. Gains the Blade-dash ability from the start. Cannot use heavy weapons, and poor use of ranged weapons.
* The ranged character - Slightly increased health and agility. Gains the burst-strike ability from the start. Poor use of melee and heavy weapons.
* The heavy weapons character - Abysmal agility, but high strength and health. Gains the pack-mule ability from the start. Cannot use melee weapons other than heavy blades. Poor use of ranged weapons.

Characters have abilities they can buy/find and improve instead of their core stats. These include

* Blade-dash (Melee)
  * Dashes ahead, greatly damaging all enemies the character passes through.
  * 5 second recharge.
  * Can dash off level edges, but can also dash over gaps.
  * Level up: Increase damage. Reduces recharge.
* Burst-strike (Ranged)
  * Shoots 3 times rapidly, using only 1 ammo.
  * 5 second recharge.
  * Level up: Increase number of times shot. Increase damage.
* Pack-mule (Character)
  * Current weapon magazine size increased by 150%.
  * Can carry surplus health and dispense as required.
  * Level up: Can carry one more weapon. Increase health surplus.
* Pierce-shot (Ranged)
  * Fires a single very powerful shot that pieces through multiple enemies.
  * 10 second recharge time.
  * Level up: Increase damage. Reduces recharge.
* Bomb-fiend (Heavy Weapons)
  * Explosive weapon projectiles split into smaller copies upon detonation.
  * Level up: Increase number of bomblets.

## Contributors

Daniel Masterson - Primary Contributor
