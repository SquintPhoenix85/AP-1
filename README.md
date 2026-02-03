# 🏗️ Sistema de Presupuestación para Construcción

Aplicación de escritorio para la **creación y gestión de presupuestos de obra**, diseñada para una firma constructora colombiana.  
El sistema permite modelar **Materiales, Equipos, Mano de Obra, APU y Presupuestos**, aplicando principios de **Programación Orientada a Objetos, Clean Architecture y SOLID**.

---

## 🎯 Objetivo del proyecto

Desarrollar un sistema:
- Extensible y mantenible
- Independiente de UI y base de datos
- Con reglas de negocio testeables
- Adaptado al contexto real de la construcción (APU)

---

## 🧱 Arquitectura

El proyecto sigue **Clean Architecture**, separando responsabilidades en capas:

Presupuestos
├── Domain
│ ├── Entities
│ ├── Enums
│ └── Interfaces
├── Application
│ └── Services
├── Infrastructure
│ ├── Data
│ │ └── Configurations (EF Core Fluent API)
│ └── Repositories
├── Tests
│ ├── Domain.Tests
│ ├── Application.Tests
│ └── Infrastructure.Tests
└── UI (pendiente)


### 📌 Capas
- **Domain**: reglas de negocio puras (sin dependencias externas).
- **Application**: casos de uso y orquestación.
- **Infrastructure**: persistencia (EF Core + SQLite).
- **Tests**: pruebas unitarias y de infraestructura.
- **UI**: interfaz de usuario (planificada).

---

## 🧠 Conceptos clave implementados

- Programación Orientada a Objetos (POO)
  - Abstracción
  - Encapsulamiento
  - Composición
  - Polimorfismo
- Principios SOLID
- Inversión de dependencias
- Repositorio genérico y específico
- Domain-driven design (ligero)
- Tests con **MSTest**
- **SQLite In-Memory** para tests de infraestructura

---

## 📊 Funcionalidades principales

- Gestión de **Materiales**
- Gestión de **Equipos**
- Gestión de **Mano de Obra**
- Creación de **APU (Análisis de Precio Unitario)**
- Creación de **Presupuestos** a partir de APUs
- Cálculo automático de costos
- Persistencia con SQLite
- Tests automatizados para:
  - Dominio
  - Application
  - Infrastructure (EF Core real)

---

## 🧪 Testing

El proyecto incluye:
- **Unit Tests** para Domain y Application
- **Infrastructure Tests** usando SQLite In-Memory para validar:
  - Mapeos de EF Core
  - Relaciones entre entidades
  - Persistencia real sin tocar disco

> Los tests permiten validar el sistema sin depender de UI ni base de datos física.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje**: C#
- **Framework**: .NET
- **ORM**: Entity Framework Core
- **Base de datos**: SQLite
- **Testing**: MSTest
- **Arquitectura**: Clean Architecture

---

## 🚧 Estado del proyecto

- [x] Domain completo
- [x] Application completa
- [x] Infrastructure completa
- [x] Tests (Domain, Application, Infrastructure)
- [ ] UI de escritorio (pendiente)
- [ ] Funcionalidades avanzadas (AIU, IVA, reportes)

---

## 📌 Próximos pasos

- Implementar UI de escritorio (WPF)
- Editor visual de APU tipo hoja de cálculo
- Exportación de presupuestos
- Cálculo de AIU e impuestos
- Persistencia histórica de precios

---

## 📄 Licencia

Proyecto académico / educativo.  
Uso libre con fines de aprendizaje.

---

## 👤 Autor

Desarrollado por **Orlando R. Arroyo Escalante**  
Estudiante de Ingeniería de Sistemas y Computación  
Universidad del Norte

