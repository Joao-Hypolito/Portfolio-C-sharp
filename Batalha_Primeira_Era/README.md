🛡️ Technical Summary: The Base Class

The Character class is an abstract class that serves as like the Blueprint for creation any hero, minion or creature in the Batalha Primeira Era universe. It implements IDamageable interface, which means that any character derived from It inherits mechanical capability to take damage and interact in combat flow.

Here is the logical division of It management:

🗂️ 1. Attributes and Data shielding (Encapsulation)

The class stores vital data and character statistics. Using the Math.Clamp property, the code unsures a strict business rule: the attributes never exceed game limits (Minimum 0, maximum 99), preventing bugs of infinite status bugs.

LifePont and armor: Control the survival and physical damage mitigation.

RPG attributes: Strength, Dexterity and Knowledge.

Spectral Insight: The unique mechanic that defines if the character can interact or perceive The Spectral Realm (activate if value is greater than or equal 50). A boolean method that verifies at runtime if the character possesses the necessary perception to interact with the Spectral Realm.

EquippedWeapon: Stores the weapon object that character equips for to use in damage calculation.

Take Action: This public method is responsible for selecting a body part on a character and applying damage after picking a target. The method is also responsible for checking the weapon and reducing its damage if necessary, according to its durability.

Receive Damage: This function calculates and applies damage to a character based on where they were hit and their armor defense.

🗂️ 2. Spectrum

This class inherits from Character and represents one of the game's bosses. What sets it apart from the others is its ability to break the will of the player-controlled character, should their discernment points prove insufficient for the confrontation.

DefendAgainstAttacker: The DefendAgainstAttacker method takes a Character object, named target, as a parameter. This boolean method evaluates the target's SpectralInsight value. If this value is below 40 points, the Spectrum decreases the player's weapon durability to zero, thereby rendering it useless during combat. Otherwise, if the insight is greater than 40, the protagonist becomes immune to the boss's attack.