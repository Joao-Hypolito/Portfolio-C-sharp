🛡️ Technical Summary: The Base Class

The Character class is an abstract class that serves as like the Blueprint for creation any hero, minion or creature in the Batalha Primeira Era universe. It implements IDamageable interface, which means that any character derived from It inherits mechanical capability to take damage and interact in combat flow.

Here is the logical division of It management:

🗂️ 1. Attributes and Data shielding (Encapsulation)

The class stores vital data and character statistics. Using the Math.Clamp property, the code unsures a strict business rule: the attributes never exceed game limits (Minimum 0, maximum 99), preventing bugs of infinite status bugs.

LifePont and armor: Control the survival and physical damage mitigation.

RPG attributes: Strength, Dexterity and Knowledge.

Spectral Insight: The unique mechanic that defines if the character can interact or perceive The Spectral Realm (activate if value is greater than or equal 50).  

EquippedWeapon: Stores the weapon object that character equips for to use in damage calculation.

