🛠️ C# Core Labs: Dominando POO
Uma coleção de sistemas práticos desenvolvidos para consolidar os pilares da Programação Orientada a Objetos em C#.

🧬 1. Projeto Biodiversidade (Gestão de Seres Vivos)
Focado em Abstração e Polimorfismo, simulando nichos ecológicos.

Destaque: Uso de abstract class e override para comportamentos específicos (sons/movimentos).

Técnica: Implementação de Type Casting (is/as) para manipular coleções genéricas de subclasses.

📚 2. Sistema Biblioteca (Gestão de Acervo)
Focado em Encapsulamento e Estrutura de Dados.

Destaque: Organização de classes para empréstimos, usuários e títulos.

Técnica: Gestão de estados (disponibilidade de itens) e integridade de dados via modificadores de acesso.

🍽️ 3. Sistema Restaurante (Controle de Pedidos)
Focado em Lógica de Fluxo e Instanciação.

Destaque: Modelagem de mesas, pedidos e faturamento.

Técnica: Relacionamento entre objetos (agregação) e manipulação de listas dinâmicas em tempo de execução.

🤖 4. Exército Decepticon (Gestão de Unidades de Combate)
Focado em Associação de Objetos: Agregação vs. Composição.

Destaque: Modelagem de hierarquia militar e robôs combinadores (Combiners).

Técnica: Implementação de relacionamentos fortes (Composição) para membros fixos do corpo e relacionamentos fracos (Agregação) para liderança dinâmica.

🛡️ 5. Escaneamento Terrorcon (Protocolo de Aquisição de Alvos)
Focado em Tomada de Decisão e Lógica de Seleção de Hardware.

Destaque: Implementação de um motor de avaliação multicritério (Combustível, Ano e Estética) para seleção de disfarces robóticos.

Técnica: Uso de Classes Abstratas para definição de contratos de verificação e lógica de Acúmulo/Penalidade de Score, incluindo filtragem de strings com sanitização de dados (ToLower) para validação de compatibilidade de chassi.

⚔️ 6. Crônicas da Primeira Era (Simulador de Combate Tático)
Focado em Lógica de Jogo, Aleatoriedade (Randomização) e Herança Avançada.

Destaque: Implementação de um motor de batalha por turnos inspirado no Legendarium de Tolkien (Silmarillion), simulando o embate épico entre heróis da Terra-Média e as forças de Morgoth.

Técnica: Polimorfismo e Sobrescrita (override): Cada classe (Guerreiro, Mago, Dragão) herda da base Personagem e reimplementa o método RealizarAcao, permitindo que um Guerreiro use força bruta enquanto um Dragão utiliza um sistema de sorteio para ataques de chamas.

Mecânica de Status: Desenvolvimento de habilidades passivas e ativas, como o "Olhar do Dragão", que utiliza lógica probabilística para aplicar efeitos de controle (terror) nos alvos, e o "Multiplicador de Vida", que demonstra a manipulação dinâmica de atributos em tempo de execução.

🏛️ 7. Digital-Twin-Greenhouse-Simulator (Gêmeo Digital de Estufa IoT)
Focado em Virtualização de Hardware, Simulação Estocástica e Resiliência de Sistemas.

Destaque: Desenvolvimento de um simulador de alta fidelidade para substituir sensores físicos instáveis, garantindo a integridade do fluxo de dados para integração com SQL e Dashboards.

Técnica: * Lógica de Inércia Térmica: Implementação de variação incremental via algoritmos probabilísticos (Random Walk) para mimetizar o comportamento físico real de temperatura e umidade, evitando saltos de dados impossíveis.

Protocolo de Injeção de Ruído: Criação de um motor de estresse para simular falhas críticas de hardware (Edge Cases), testando a capacidade de recuperação do sistema e a robustez da lógica de acionamento de atuadores.

Feedback Loop: Modelagem de controle em tempo real onde o estado do "Atuador" (Ventilador/Aquecedor) influencia dinamicamente a tendência de subida ou descida da variável simulada, criando um ecossistema autoajustável.

🚀 Tecnologias e Conceitos
Linguagem: C# (.NET 10.0)

Conceitos: Classes Abstratas, Herança, Polimorfismo, Encapsulamento e Type Casting.

IDE: Visual Studio / VS Code
