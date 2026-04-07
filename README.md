# UnityAlchemyLab
A development lab for crafting reusable Unity systems through experimentation — where gameplay mechanics, simulation logic, and tools are refined into clean, modular code.

UnityAlchemyLab/
│
├── Runtime/                # ใช้ในเกมจริง
│   ├── Core/               # ระบบพื้นฐาน
│   │   ├── Singleton.cs
│   │   ├── EventBus.cs
│   │   └── ServiceLocator.cs
│   │
│   ├── Gameplay/           # ระบบ gameplay
│   │   ├── Movement/
│   │   │   └── PlayerMovement.cs
│   │   ├── Camera/
│   │   │   └── CameraFollow.cs
│   │   ├── Interaction/
│   │   │   └── Interactable.cs
│   │
│   ├── Simulation/         # 🔥 จุดเด่นคุณ
│   │   ├── Motion/
│   │   │   └── GantryController.cs
│   │   ├── Physics/
│   │   │   └── ConstraintSystem.cs
│   │
│   ├── Systems/            # ระบบ reusable
│   │   ├── Health/
│   │   │   └── HealthSystem.cs
│   │   ├── Inventory/
│   │   │   └── InventorySystem.cs
│   │
│   ├── Utilities/          # helper
│   │   ├── Timer.cs
│   │   ├── MathUtils.cs
│   │   └── Extensions.cs
│
├── Editor/                 # tools ใน Unity Editor
│   ├── Inspectors/
│   └── Windows/
│
├── Samples~/               # ตัวอย่าง (Unity package style)
│   ├── DemoScene
│   └── ExampleScripts
│
├── Documentation~/         # docs แยก
│   ├── GettingStarted.md
│   └── Architecture.md
│
├── Tests/                  # (optional แต่โปรมาก)
│   ├── Runtime/
│   └── Editor/
│
├── package.json           # ถ้าทำเป็น Unity Package
├── README.md
└── LICENSE
