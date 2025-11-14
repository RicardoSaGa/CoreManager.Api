# 🚀 CoreManager.Api --- Backend RESTful (ASP.NET Core + SQL Server)

CoreManager.Api es un backend construido con **ASP.NET Core Web API** y
**Entity Framework Core**, diseñado para administrar información de
Clientes, Empleados, Tipos de Empleado y Tipos de Persianas. El proyecto
implementa un CRUD completo para cada entidad y utiliza
**Swagger/OpenAPI** para documentación interactiva.

Este backend forma parte del sistema CoreManager, pensado para
integrarse con un frontend moderno desarrollado en React.

## 🧱 Arquitectura del Proyecto

El proyecto está organizado siguiendo buenas prácticas, separando
responsabilidades de forma clara:

    CoreManager.Api/
    ├── Controllers/       → Controladores REST
    ├── Models/            → Modelos de dominio (entidades)
    ├── Data/              → DbContext y acceso a datos
    ├── Program.cs         → Configuración principal
    ├── appsettings.json   → Configuración y cadena de conexión
    └── CoreManager.Api.csproj

Tecnologías utilizadas:

-   **ASP.NET Core 7**
-   **Entity Framework Core (Code First)**
-   **SQL Server**
-   **Swagger / OpenAPI**
-   **Inyección de dependencias**
-   **Programación asíncrona (async/await)**

## 📌 Funcionalidades Principales

El backend proporciona operaciones CRUD completas para cada módulo:

### ✔ Clientes

-   Crear, listar, editar y eliminar clientes\
-   Campos: `Id`, `Nombre`, `Direccion`

### ✔ Tipos de Empleado

-   Catálogo para clasificar empleados\
-   Campos: `Id`, `NombreTipo`

### ✔ Empleados

-   Relación con Tipos de Empleado\
-   Campos: `Id`, `Nombre`, `TipoEmpleadoId`, `TipoEmpleado`

### ✔ Tipos de Persianas

-   Catálogo de productos\
-   Campos: `Id`, `NombreTipo`, `PrecioMetroCuadrado`

Todos los controladores están basados en principios REST y devuelven
respuestas JSON limpias y estandarizadas.

## 🛢 Base de Datos

Asegúrate de tener una base de datos en SQL Server llamada:

    CoreManagerDB

Con la siguiente cadena de conexión en `appsettings.json`:

``` json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CoreManagerDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Si usas usuario y contraseña:

``` json
"DefaultConnection": "Server=localhost;Database=CoreManagerDB;User Id=sa;Password=TU_PASSWORD;TrustServerCertificate=True;"
```

## ▶ Cómo Ejecutar el Proyecto

1.  Clona el repositorio

``` bash
git clone https://github.com/TU_USUARIO/CoreManager.Api.git
```

2.  Entra al directorio

``` bash
cd CoreManager.Api
```

3.  Restaura dependencias

``` bash
dotnet restore
```

4.  Ejecuta la API

``` bash
dotnet run
```

## 📖 Documentación con Swagger

Una vez que el proyecto está corriendo, abre:

    https://localhost:{puerto}/swagger/index.html

Desde ahí puedes probar cada endpoint sin herramientas externas.

## 🔗 Relación entre entidades

    TiposEmpleado (1) ------ (N) Empleados
    TiposPersiana ---------- Catálogo independiente
    Clientes ---------------- Entidad independiente

Los modelos fueron diseñados para ser consumidos fácilmente desde un
frontend moderno en React.

## 🧪 Ejemplo de Request (Empleado)

### POST /api/Empleados

``` json
{
  "nombre": "Juan Pérez",
  "tipoEmpleadoId": 1
}
```

Respuesta:

``` json
{
  "id": 5,
  "nombre": "Juan Pérez",
  "tipoEmpleadoId": 1,
  "tipoEmpleado": null
}
```

## ✨ Objetivo del Proyecto

Este backend representa una solución profesional para una prueba
técnica, implementando:

-   Arquitectura ordenada\
-   CRUD completo\
-   Buenas prácticas REST\
-   Base sólida para un frontend

El repositorio acompaña a un proyecto React independiente que consume
esta API.
