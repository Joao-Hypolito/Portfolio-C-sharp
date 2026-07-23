
🛠️ C# Core Labs: Dominating OOP
A collection of practical systems developed to consolidate the pillars of Object-Oriented Programming (OOP) in C#.

## 🤖 1. Decepticon Arm (Combat Management Units)
| Focus: Relationship Modeling (Aggregation and Composition). |
| :--- |

**Highlight:** Designed the military command structure and the architecture of combiner robots.

**Technique:** Applied **Composition** to represent permanent body components and **Aggregation** to model flexible command relationships.

---

## 🏛️ 2. Digital-Twin-Greenhouse-Simulator
| Focus: Hardware Emulation, Probabilistic Simulation, and Fault Tolerance. |
| :--- |

**Highlight:** Built a realistic virtual environment that replaces unreliable physical sensors, maintaining consistent data acquisition for SQL databases and dashboard visualization. 

> [!NOTE]
> **Technical Details:**

| Attribute | Description |
| :--- | :--- |
| **Thermal Inertia Logic:** | Implemented incremental variation via probabilistic algorithms (Random Walk) to mimic the real-world physical behavior of temperature and humidity, preventing impossible data spikes. |
| **Noise Injection Protocol:** | Created a stress engine to simulate critical hardware failures (Edge Cases), testing system recovery capabilities and the robustness of actuator triggering logic.|
| **Feedback Loop:** | Modeled real-time control loops where the "Actuator" state (Fan/Heater) dynamically influences the upward or downward trend of the simulated variable, creating a self-adjusting ecosystem.|

## 🏛️ 3. School Library System (LibraryCrud)
| Focused on Desktop Architecture, Multilayer Data Access, and Relational database integrity. |
| :--- |

Highlight: Developed an enterprise-grade school library management system from scratch using C# Windows Forms and SQL Server LocalDB, featuring fault-tolerant data operations, enforced domain constraints, and asynchronous feedback loops.

> [!NOTE]
> **Technical Details:**

| Attribute | Description |
| :--- | :--- |
| **Relational Database Design**: | Engineered a triple-entity relational topology (`Livros`, `Leitores`, `Emprestimos`) complete with Primary Keys, Auto-Increments, and Foreign Key constraints to bind entities into deterministic relationship mapping. |
| **Atomic State Updates (Delta Logic)**: | Implemented inline SQL update streams (`UPDATE Livros SET Quantidade = Quantidade + @delta`) where `@delta` dynamically adjusts by `-1` (loan) or `+1` (return), ensuring concurrency control and multi-user transactional stability. |
| **Polymorphic Data Binding**: | Utilized explicit `DisplayMember` and `ValueMember` abstraction layers on WinForms `ComboBox` control structures, enabling seamless Object-to-UI binding and fetching primary identifiers cleanly via `SelectedValue`. |
| **Dynamic Conditional UI Rendering**: | Integrated a synchronous inspection engine inside the `DataGridView` framework to run during the `DataBindingComplete` cycle, dynamically altering row styles based on loan statuses (e.g., green for returned, soft red for overdue items). |

## 🚀 Key Architectural Features
* `Strict Layer Separation:` Isolated database connection contexts and parameterized commands within robust repository implementations (Data, Models, Repositories, Forms), guaranteeing code maintainability and clear testing boundaries.
* `Downstream Constraints:` Engineered pre-execution validation checks that instantly block loans if a specific book's physical inventory drops to 0, automatically removing depleted titles from active UI combo controls.
* `Enhanced UX Framework:` Thoroughly mapped custom TabOrder sequencing across all inputs, standardized keyboard shortcut operations (Ctrl+N, Ctrl+S, Ctrl+E, Del, Esc), and deployed an automatic Timer thread to dismiss success banners after 4 seconds.

## 🚀 Technologies and Concepts Language: C# (.NET 10.0)

### Concepts: Abstract Classes, Inheritance, Polymorphism, Encapsulation, and Type Casting.

> [IDE:]
Visual Studio / VS Code
