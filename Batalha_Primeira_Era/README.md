🛡️ Technical Summary: The Base Class

The Character class is an abstract class that serves as like the Blueprint for creation any hero, minion or creature in the Batalha Primeira Era universe. It implements IDamageable interface, which means that any character derived from It inherits mechanical capability to take damage and interact in combat flow.

Here is the logical division of It management:

🗂️ 1. Attributes and Data shielding (Encapsulation)

The class stores vital data and character statistics. Using the Math.Clamp property, the code unsures a strict business rule: the attributes never exceed game limits (Minimum 0, maximum 99), preventing bugs of infinite status bugs.

Vida (lifePont) e Armadura (Armor): Controlam a sobrevivência e a mitigação física do dano.

Atributos de RPG: Força (Strength), Destreza (Dexterity) e Conhecimento (Knowledge).

Discernimento Espectral (SpectralInsight): Uma mecânica única que define se o personagem consegue interagir ou perceber o Reino Espectral (ativada caso o valor seja maior ou igual a 50).

Arma Equipada (EquippedWeapon): Guarda o objeto da arma que o personagem está empunhando para usar nos cálculos de ataque.