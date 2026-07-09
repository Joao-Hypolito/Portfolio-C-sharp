
🛠️ C# Core Labs: Dominating OOP
A collection of practical systems developed to consolidate the pillars of Object-Oriented Programming (OOP) in C#.

🤖 1. Decepticon Arm (Combat Management Units)
Focus: Object Association (Aggregation vs. Composition).

Highlight: Modeling military hierarchy and combiner bots.

Technique: implementing Strong Relationships (Composition) for fixed body members and Weak relationships (Aggregation) for dynamics leadership.

🏛️ 2. Digital-Twin-Greenhouse-Simulator
Focused on Hardware Virtualization, Stochastic Simulation, and System Resilience.

Highlight: Developed a high-fidelity simulator to replace unstable physical sensors, ensuring data stream integrity for SQL and Dashboard integration.

Technical Details:

Thermal Inertia Logic: Implemented incremental variation via probabilistic algorithms (Random Walk) to mimic the real-world physical behavior of temperature and humidity, preventing impossible data spikes.

Noise Injection Protocol: Created a stress engine to simulate critical hardware failures (Edge Cases), testing system recovery capabilities and the robustness of actuator triggering logic.

Feedback Loop: Modeled real-time control loops where the "Actuator" state (Fan/Heater) dynamically influences the upward or downward trend of the simulated variable, creating a self-adjusting ecosystem.

🏛️ 3. School Library System (LibraryCrud)
Focused on Windows Forms Architecture, Multilayer Data Access, and Relational Database Integrity.

Highlight: Developed a comprehensive school library management system from scratch using C# Windows Forms and SQL Server LocalDB, featuring safe data operations, automated business rules, and asynchronous feedback loops.

Technical Details:

* **Relational Database Design**: Formulated a 3-table normalized schema (`Livros`, `Leitores`, `Emprestimos`) complete with Primary Keys, Auto-Increments, and Double Foreign Key constraints to bind readers and books into deterministic relationship mapping.
* **Atomic State Updates (Delta Logic)**: Implemented inline SQL update streams (`UPDATE Livros SET Quantidade = Quantidade + @delta`) where `@delta` dynamically adjusts by `-1` (loan) or `+1` (return), guaranteeing data race prevention and multi-user transactional stability.
* **Polymorphic Data Binding**: Leveraged explicit `DisplayMember` and `ValueMember` abstraction layer mappings on WinForms `ComboBox` control structures, allowing clean Object-to-UI binding and fetching primary identifiers cleanly via `SelectedValue`.
* **Dynamic Conditional UI Rendering**: Hooked into the `DataBindingComplete` cycle inside the `DataGridView` framework to run a synchronous inspection engine over rows, instantly changing row backgrounds dynamically based on loan status (e.g., green for returned, soft red for overdue items).

## 🚀 Key Architectural Features
* **Strict Layer Separation**: Decoupled database connection contexts and parameterized commands inside strong repository implementations (`Data`, `Models`, `Repositories`, `Forms`), ensuring code maintainability and testing boundaries.
* **Downstream Constraints**: Built pre-execution validation checks that block loans immediately if a specific book's physical record counts reach `0`, automatically dropping exhausted instances out of active UI combo controls.
* **Enhanced UX Framework**: Fully mapped custom `TabOrder` sequencing across all fields, unified keyboard shortcut operations (`Ctrl+N`, `Ctrl+S`, `Ctrl+E`, `Del`, `Esc`), and implemented an automatic `Timer` thread to clear action success banners after 4 seconds.

🚀 Technologies and Concepts Language: C# (.NET 10.0)

Concepts: Abstract Classes, Inheritance, Polymorphism, Encapsulation, and Type Casting.

IDE: Visual Studio / VS Code
