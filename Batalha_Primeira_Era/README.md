🛡️ Technical Summary: The Base Class

The Character class is an abstract class that serves as the definitive blueprint for creating any hero, minion, or creature within the Batalha Primeira Era universe. Furthermore, it implements the IDamageable interface. Consequently, any character derived from this base class inherently acquires the mechanical capability to receive damage and seamlessly interact within the combat flow.  

Here is the logical division of its structural management: 

🗂️ 1. Attributes and Data shielding (Encapsulation)

The class stores vital data and character statistics. Using the Math.Clamp method, the code ensures a strict business rule: the attributes never exceed game limits (minimum 0, maximum 99), preventing infinite status bugs.

LifePoints and Armor: Control survival and physical damage mitigation.

RPG Attributes: Strength, Dexterity, and Knowledge.

Spectral Insight: The unique mechanic that defines whether the character can interact with or perceive the Spectral Realm (activates if the value is greater than or equal to 50). A boolean method verifies at runtime whether the character possesses the necessary perception to interact with the Spectral Realm.

EquippedWeapon: Stores the weapon object that the character equips to use in damage calculation.

Take Action: This public method is responsible for selecting a target, choosing a body part, and applying damage. The method is also responsible for checking the weapon and reducing its damage if necessary, according to its durability.

Receive Damage: This function calculates and applies damage to a character based on where they were hit and their armor defense.

🗂️ 2. Bosses

1. Spectrum

    This class inherits from Character and represents one of the game's bosses. What sets it apart from the others is its ability to break the will of the player-controlled character, should their discernment points prove insufficient for the confrontation.

    DefendAgainstAttacker: The DefendAgainstAttacker method takes a Character object, named target, as a parameter. This boolean method evaluates the target's SpectralInsight value. If this value is below 40 points, the Spectrum decreases the player's weapon durability to zero, thereby rendering it useless during combat. Otherwise, if the insight is greater than 40, the protagonist becomes immune to the boss's attack.

2. Dragon

    The Dragon class represents one of the primary and most formidable bosses within the Batalha Primeira Era universe. It inherits directly from the core Character class, expanding its mechanical complexity and threat level in combat.

    1. Targetable Body Parts (GetTargetTableParts)
    The class overrides the base target table system to introduce localized damage mechanics. In addition to standard character hitboxes, players can strategically target a Dragon's specific vulnerabilities:
        BodyPart.Wings: Allows players to target the wings (potentially affecting mobility or airborne actions).
        BodyPart.Belly: Exposes the traditional weak point of ancient drakes for high-risk, high-reward tactical strikes.

    2. Boss Scaling (LifeMultiplier)
    To reflect its status as an apex predator of the First Age, the class features a dynamic health-scaling method:
        Multiplication Factor: Instantly scales the Dragon's current health pool by 10x (lifePont *= 10). This ensures a massive, multi-phased challenge during encounter transitions.


🗂️ 3. Heroes 

Heroes: The classes inherits from Character, a hybrid hero in the game Batalha_Primeira_Era. It is a subclass that demonstrates a solid understanding of Object-Oriented Programming (OOP) principles in C#, specifically Inheritance, Interfaces with Generics, and Constructor Overloading (Polymorphism).

🗂️ 4. Weapons

Weapons: This class encapsulates the specific attributes and behaviors of weaponry for each hero class, thereby enhancing both code readability and overall system maintainability. By leveraging this structural design, the class exposes the CalculateDamage method, which not only computes the final strike value but also dynamically manages and overrides the weapon's durability during combat sequences. Consequently, this centralized logic ensures that combat calculations remain consistent and easily scalable as new hero classes or equipment types are introduced.