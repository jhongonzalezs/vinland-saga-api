# ⚔️ Vinland Saga API

API REST desarrollada con **ASP.NET Core 10** para gestionar personajes del universo de *Vinland Saga*.

---

## 🛠️ Tecnologías

- .NET 10
- ASP.NET Core
- C#
- Swagger (Swashbuckle)

---

## 📁 Estructura

```
├── Controllers/
│   └── PersonajesController.cs
├── Data/
│   └── VinlandDb.cs
├── Models/
│   └── Personaje.cs
├── Program.cs
└── README.md
```

---

## 🚀 Cómo ejecutar

```bash
git clone https://github.com/jhongonzalezs/vinland-saga-api.git
cd vinland-saga-api
dotnet watch
```

Luego abre: http://localhost:5139/swagger

---

## 📋 Endpoints

| Método | Ruta | Descripción |
|---|---|---|
| GET | `/api/personajes` | Lista todos los personajes |
| GET | `/api/personajes/{id}` | Obtiene uno por ID |
| GET | `/api/personajes/buscar?nombre=X` | Busca por nombre |
| GET | `/api/personajes/vivos` | Personajes vivos |
| GET | `/api/personajes/top-kills` | Top 3 asesinos |
| POST | `/api/personajes` | Crea un personaje |
| PUT | `/api/personajes/{id}` | Actualiza un personaje |
| DELETE | `/api/personajes/{id}` | Elimina un personaje |

---
