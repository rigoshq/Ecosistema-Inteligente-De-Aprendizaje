# Arquitectura del Ecosistema Inteligente de Aprendizaje (EIA)

## 1. Objetivo

Este documento describe la arquitectura oficial del Ecosistema Inteligente de Aprendizaje (EIA), sus principios de diseño y las reglas que deberán respetarse durante todo el desarrollo del proyecto.

El objetivo principal es garantizar que el sistema pueda evolucionar durante muchos años sin perder organización, mantenibilidad ni escalabilidad.

---

# 2. Principios

El desarrollo del EIA se fundamenta en los siguientes principios:

- Clean Architecture
- SOLID
- Separación de responsabilidades
- Bajo acoplamiento
- Alta cohesión
- Escalabilidad
- Mantenibilidad
- Testabilidad

Ninguna decisión técnica deberá violar estos principios.

---

# 3. Arquitectura General

```
                 +----------------------+
                 |     Electron App     |
                 +----------+-----------+
                            |
                            |
                 REST API (.NET 10)
                            |
        +-------------------+-------------------+
        |                                       |
        v                                       v
+----------------+                  +------------------+
|    EIA.Api     |                  |    Unity 3D      |
+----------------+                  +------------------+
          |
          v
+----------------+
|    EIA.Core    |
+----------------+
          |
          v
+----------------+
|   EIA.Domain   |
+----------------+
          ^
          |
+----------------------+
| EIA.Infrastructure   |
+----------------------+
```

---

# 4. Responsabilidad de cada proyecto

## EIA.Api

Responsable de:

- Exponer la API REST.
- Recibir solicitudes HTTP.
- Configurar la aplicación.
- Registrar servicios.

No contiene lógica de negocio.

---

## EIA.Core

Responsable de:

- Casos de uso.
- Servicios de aplicación.
- DTOs.
- Interfaces de repositorios.

Toda la lógica de aplicación vive aquí.

---

## EIA.Domain

Responsable de:

- Entidades.
- Objetos de valor.
- Reglas del dominio.
- Enumeraciones.

El dominio no conoce ninguna tecnología externa.

---

## EIA.Infrastructure

Responsable de:

- Persistencia.
- Repositorios.
- Seeders.
- Acceso a archivos.
- Base de datos.
- Integraciones.

---

## EIA.Shared

Responsable de:

- Utilidades comunes.
- Constantes.
- Excepciones.
- Extensiones.

---

# 5. Flujo de Dependencias

Las dependencias solo pueden apuntar hacia el dominio.

```
Api
 ↓
Core
 ↓
Domain

Infrastructure
      ↓
Domain
```

Nunca deberá existir una referencia desde Domain hacia Infrastructure o Api.

---

# 6. Organización futura

La solución crecerá con los siguientes módulos:

- Exploradores
- Mundo
- Ciudades
- Edificios
- NPC
- Misiones
- Física
- Matemáticas
- Química
- Inglés
- IA
- Simuladores
- Inventario
- Economía
- Logros
- Moodle
- Unity
- Electron

Todos deberán respetar esta arquitectura.

---

# 7. Convención

Antes de implementar cualquier nueva funcionalidad se deberá responder:

- ¿En qué capa pertenece?
- ¿Viola Clean Architecture?
- ¿Puede reutilizarse?
- ¿Puede probarse mediante pruebas unitarias?

Solo después de responder estas preguntas se implementará el código.