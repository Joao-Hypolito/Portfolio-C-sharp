🛡️ Resumo Técnico: A Classe Mãe Character
A classe Character é uma classe abstrata que serve como a base (o molde principal) para a criação de qualquer herói, peão ou criatura dentro do universo de Batalha Primeira Era. Ela implementa a interface IDamageable, o que significa que qualquer personagem derivado dela herda a capacidade mecânica de receber dano e interagir no fluxo de combate.

Aqui está a divisão lógica do que ela gerencia:

🗂️ 1. Atributos e Blindagem de Dados (Encapsulamento)
A classe armazena os dados vitais e estatísticas do personagem. Usando a propriedade Math.Clamp, o código garante uma regra de negócio rígida: os atributos nunca passam dos limites do jogo (mínimo 0, máximo 99), evitando bugs de status infinito.

Vida (lifePont) e Armadura (Armor): Controlam a sobrevivência e a mitigação física do dano.

Atributos de RPG: Força (Strength), Destreza (Dexterity) e Conhecimento (Knowledge).

Discernimento Espectral (SpectralInsight): Uma mecânica única que define se o personagem consegue interagir ou perceber o Reino Espectral (ativada caso o valor seja maior ou igual a 50).

Arma Equipada (EquippedWeapon): Guarda o objeto da arma que o personagem está empunhando para usar nos cálculos de ataque.