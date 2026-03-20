# Sistema de Aprobación de Créditos

Aplicación de escritorio desarrollada en C# con .NET 10.0 que implementa un sistema de preaprobación de solicitudes de crédito con validación de riesgo crediticio.

## 📋 Descripción

Este proyecto es una solución empresarial que implementa la lógica de negocio para evaluar y preapprobar solicitudes de crédito. Utiliza una **arquitectura de capas** (N-Layer Architecture) que separa las responsabilidades entre acceso a datos, lógica de negocio y presentación.

### Funcionalidades Principales

- ✅ Validación de parámetros de crédito (plazo, ingresos, egresos)
- 📊 Cálculo de relación crédito-balanza
- 🔍 Consulta de puntaje crediticio en central de riesgo
- ✔️ Preaprobación automática basada en umbrales configurables
- 🧪 Pruebas unitarias integradas

## 🏗️ Arquitectura

El proyecto sigue una arquitectura de **3 capas**:

```
├── CapaAccesoDatos/     → Acceso a Base de Datos
│   ├── ConexionSQLServer.cs
│   └── IFuenteDeDatos.cs (Interfaz)
│
├── CapaNegocio/         → Lógica de Negocio
│   ├── Logica.cs (Motor de decisión)
│   ├── SolicitudCredito.cs (Modelo)
│   └── IFuenteDeDatos.cs (Implementa interfaz)
│
├── CapaPresentacion/    → Interfaz de Usuario (Windows Forms)
│   ├── Form1.cs (UI Principal)
│   └── Program.cs
│
└── PruebasUnitarias/    → Tests
    └── LogicaTest.cs
```

## 🔑 Características Técnicas

### Reglas de Negocio

- **Validación de Plazo**: Entre 1 y 72 meses
- **Validación de Balanza**: Ingresos - Egresos > 0
- **Relación Crédito-Balanza**: `(Monto / Plazo) / Balanza`
- **Consulta de Puntaje**: Si relación ≥ 0.95
- **Aprobación**: Puntaje crediticio ≥ 800

### Retorno de Datos

La lógica devuelve tuplas con:
- `bool aprobado` - Resultado de la aprobación
- `string mensaje` - Explicación del resultado

## 🛠️ Requisitos

- **.NET SDK 10.0** o superior
- **SQL Server** (Express o superior)
- **Visual Studio 2022** (opcional pero recomendado)

## 📦 Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/usuario/Parcial-Arquitectura-Software.git
cd "Parcial-Arquitectura-Software"
```

### 2. Crear la Base de Datos

Ejecuta el script SQL en SQL Server:

```bash
sqlcmd -S .\SQLEXPRESS -i "Script Tabla.sql"
```

O manualmente en SQL Server Management Studio:
- Abre `Script Tabla.sql`
- Ejecuta el script para crear la tabla `ingresos` en la base de datos `Parqueadero`

### 3. Restaurar dependencias

```bash
dotnet restore
```

### 4. Compilar la solución

```bash
dotnet build
```

### 5. Ejecutar la aplicación

```bash
cd CapaPresentacion
dotnet run
```

## 🧪 Pruebas Unitarias

Ejecuta las pruebas con:

```bash
cd PruebasUnitarias
dotnet test
```

O desde Visual Studio:
- Test → Run All Tests (Ctrl + R, A)

## 📝 Uso

1. Inicia la aplicación
2. Completa el formulario con los datos de la solicitud de crédito
3. El sistema validará automáticamente los parámetros
4. Obtendrás un resultado de preaprobación con explicación detallada

## 🗂️ Estructura de Archivos

```
Parcial 1 AS/
├── CapaAccesoDatos/
│   ├── ConexionSQLServer.cs      # Conexión a BD
│   └── CapaAccesoDatos.csproj
├── CapaNegocio/
│   ├── Logica.cs                 # Motor de decisión
│   ├── SolicitudCredito.cs       # Modelo de datos
│   ├── IFuenteDeDatos.cs         # Contrato de interfaz
│   └── CapaNegocio.csproj
├── CapaPresentacion/
│   ├── Form1.cs                  # Interfaz principal
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Program.cs                # Entry point
│   └── CapaPresentacion.csproj
├── PruebasUnitarias/
│   ├── LogicaTest.cs             # Tests
│   └── PruebasUnitarias.csproj
├── Script Tabla.sql              # DDL de BD
└── Parcial1 AS.slnx              # Solución
```

## 💻 Tecnologías Utilizadas

| Componente | Versión |
|-----------|---------|
| .NET SDK | 10.0 |
| C# | 13.0 |
| SQL Server | 2019+ |
| Windows Forms | .NET 10.0 |
| MSTest | (Test Framework) |

## 👥 Autor Andrés Gómez Sepúlveda
