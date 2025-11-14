# CoreManager.Api  
Backend desarrollado en .NET 8 para la prueba técnica de Desarrollador JR.  
El proyecto implementa una API REST conectada a SQL Server, manejando módulos de Clientes, Empleados y Tipos de Empleado.

## 🚀 Tecnologías utilizadas

- ASP.NET Core 8 (Web API)
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- C#

## 📦 Arquitectura general

El proyecto sigue una estructura limpia basada en controladores (Controllers) y modelos (Models):

CoreManager.Api/
 ├── Controllers/
 ├── Models/
 ├── Data/
 ├── appsettings.json
 ├── Program.cs
 └── CoreManager.Api.http

## 🗄 Base de Datos  
Este backend utiliza la base de datos **CoreManagerDB** en SQL Server.

En este repositorio encontrarás:

### ✔ `Database/CoreManagerDB-ERD.png`
Diagrama ERD generado desde SQL Server.

### ✔ `Database/CoreManagerDB-Script.sql`
Script completo para crear la base de datos, tablas y relaciones.

*Requieres ejecutar el query para crear la DB*

## 📊 Modelo de Base de Datos (ERD)

El sistema está compuesto por las siguientes entidades y relaciones:

- Clientes
- TiposEmpleado
- Empleados
- TiposPersiana (opcional según requerimiento)

El diagrama muestra una relación **1:N** entre TiposEmpleado → Empleados.

![ERD](Database/CoreManagerDB-ERD.png)

## 🛠 Instalación y configuración

### 1️⃣ Clonar el repositorio
```
git clone https://github.com/TU_USUARIO/CoreManager.Api.git
```

### 2️⃣ Configurar la base de datos

1. Abrir SQL Server Management Studio (SSMS)
2. Crear la base ejecutando el archivo:

Database/CoreManagerDB-Script.sql

3. Verificar que la base **CoreManagerDB** fue creada correctamente.

## 🔧 Configurar la cadena de conexión

Editar appsettings.json:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR;Database=CoreManagerDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Reemplazar TU_SERVIDOR por tu instancia local.

## ▶ Ejecutar la API

```
dotnet run
```

Abrir Swagger:

https://localhost:7153/swagger/index.html

## 📡 Conexión con el Frontend

Este backend está diseñado para integrarse con:

CoreManager.Web (React)

Asegúrate de tener el backend ejecutándose antes del frontend.

## 📄 Licencia
Uso académico para la prueba técnica.

## 👨‍💻 Autor
RICARDO SAUCEDO
