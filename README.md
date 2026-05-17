🛠️ C# Core Labs: Dominating OOP A collection of practical systems developed to consolidate the pillars of Object-Oriented Programming (OOP) in C#.

🧬 1. Biodiversity Project (Ecological System Simulation) Focus: Abstraction and Polymorphism within ecological niches.

Highlight: Use of Abstract Classes and Method Overriding to define specific biological behaviors (e.g., vocalization and movement).

Technique: Implementing Type Casting (is / as) to safely manage and interact with generic collections of subclasses.

📚 2. Library System (Inventory & Loan Management) Focus: Encapsulation and Data Integrity.

Highlight: Structured class hierarchy for managing loans, users, and book titles.

Technique: State Management (item availability) and enforcement of business rules via Access Modifiers (private/protected).

🍽️ 3. Restaurant System (Order & Billing Control) Focus: Program Flow and Object Instantiation.

Highlight: Real-world modeling of tables, customer orders, and automated billing.

Technique: Object Composition and runtime manipulation of Dynamic Lists (List) for real-time order processing.

🤖 4. Decepticon Arm (Combat Management Units) Focus: Object Association (Aggregation vs. Composition).

Highlight: Modeling military hierarchy and combiner bots.

Technique: implementing Strong Relationships (Composition) for fixed body members and Weak relationships (Aggregation) for dynamics leadership.

🛡️ 5. Scanning Terrorcon (Target Acquisition Protocol) Focus: Decision selection logic and decision-making.

Highlight: Implementing a multi-criteria evaluation engine (fuel, year, and aesthetics) for selecting "Robots in Disguise".

Technique: Use of Abstract Classes to define verification contracts and Score/Penalty logic. Includes string filtering with data sanitization (ToLower()) for chassis compatibility validation.

⚔️ 6. Chronicles of the First Age (Tactical Combat Simulator) Focus: On Game Logic, Randomness, and Advanced Inheritance.

Highlight: Implementation of a turn-based battle engine inspired by Tolkien's Legendarium (The Silmarillion), simulating the epic clash between heroes of Middle-earth and the forces of Morgoth.

Architecture: Implementation of Dependency Inversion, where damage calculation is delegated to abstract weapon classes. This allows the combat engine to be extensible: new weapons and modifiers can be added without altering the base code of the entities.

Technique: Polymorphism and Override: Each class (Warrior, Mage, Dragon) inherits from the Character base and reimplements the PerformAction method, allowing a Warrior to use brute force while a Dragon uses a randomization system for flame attacks.

Status Mechanics: Development of passive and active skills, such as "Dragon's Gaze," which uses probabilistic logic to apply control (terror) effects to targets, and "Life Multiplier," which demonstrates the dynamic manipulation of attributes at runtime.

🏛️ 7. Digital-Twin-Greenhouse-Simulator (Gêmeo Digital de Estufa IoT) Focado em Virtualização de Hardware, Simulação Estocástica e Resiliência de Sistemas.

Destaque: Desenvolvimento de um simulador de alta fidelidade para substituir sensores físicos instáveis, garantindo a integridade do fluxo de dados para integração com SQL e Dashboards.

Técnica: * Lógica de Inércia Térmica: Implementação de variação incremental via algoritmos probabilísticos (Random Walk) para mimetizar o comportamento físico real de temperatura e umidade, evitando saltos de dados impossíveis.

Protocolo de Injeção de Ruído: Criação de um motor de estresse para simular falhas críticas de hardware (Edge Cases), testando a capacidade de recuperação do sistema e a robustez da lógica de acionamento de atuadores.

Feedback Loop: Modelagem de controle em tempo real onde o estado do "Atuador" (Ventilador/Aquecedor) influencia dinamicamente a tendência de subida ou descida da variável simulada, criando um ecossistema autoajustável.

🚀 Tecnologias e Conceitos Linguagem: C# (.NET 10.0)

Conceitos: Classes Abstratas, Herança, Polimorfismo, Encapsulamento e Type Casting.

IDE: Visual Studio / VS Code