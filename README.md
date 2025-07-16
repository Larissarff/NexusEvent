# NexusEvents – Sistema de Gestão de Eventos Corporativos com Reconhecimento Facial

### 📋 Sobre o Projeto

NexusEvents é uma plataforma completa para o gerenciamento de eventos corporativos, desenvolvida para demonstrar habilidades práticas em ASP.NET Core, Angular, Python (FastAPI), MySQL, Docker e DevOps. O sistema permite desde o cadastro de eventos até o controle de acesso com reconhecimento facial.


---

### 🚀 Funcionalidades

✅ Autenticação JWT (Admin, Organizador, Convidado)

✅ CRUD de Eventos e Reservas

✅ Painel administrativo (Dashboard)

✅ Controle de entrada via reconhecimento facial

✅ Registro de logs e histórico de eventos

✅ Upload de documentos relacionados aos eventos

✅ API RESTful modular (backend .NET)

✅ Microserviço Python para verificação facial

✅ Aplicação responsiva com Angular + SSR

✅ Containerização completa via Docker



---

### 🏛️ Tecnologias Utilizadas

ASP.NET Core 6+ (API backend)

Entity Framework Core (ORM)

Angular + Angular Universal (SSR)

FastAPI + DeepFace (Reconhecimento Facial)

MySQL (Banco de Dados)

Docker e Docker Compose

GitHub Actions (CI/CD)

Autenticação JWT



---

### 📐 Arquitetura do Sistema

Frontend Angular SSR

Backend ASP.NET Core (API RESTful)

Microserviço Python (FastAPI + DeepFace)

Banco de Dados MySQL

Orquestração via Docker Compose


Comunicação entre serviços via APIs HTTP.


---

### 📂 Estrutura do Projeto

GestaoEventosSystem/

├── backend/Api/

├── frontend/

├── facial_recognition/

├── docker-compose.yml

└── README.md

Cada serviço contém seu próprio Dockerfile.


---

### 📦 Como Executar Localmente

Pré-requisitos:

Docker e Docker Compose instalados


Comandos:

    git clone REPOSITORIO_URL

    docker-compose up --build

Acesse:

Frontend:  http://localhost:4200

API Backend: http://localhost:5000

API Facial Recognition: http://localhost:8000



---

### 🧪 Testes Automatizados

Backend: xUnit

Frontend: Jasmine/Karma


Para rodar testes:

# Backend
    cd backend/Api

    dotnet test

# Frontend
    cd frontend
    
    npm run test


---

### 📋 Metodologia

Projeto desenvolvido simulando metodologia Scrum:

Sprints semanais simuladas

Backlog e tarefas registradas

Versionamento Git com GitFlow

Pull Requests e Code Review simulados

Entregas incrementais com integração contínua



---

### 📄 Endpoints Principais

/api/auth/register – Registro de usuário

/api/auth/login – Autenticação (retorna JWT)

/api/events – CRUD de eventos

/api/reservations – CRUD de reservas

/verify-face (Python) – Verificação facial



---

📎 Considerações Finais

Este projeto demonstra domínio prático em backend .NET, frontend Angular, microserviços Python, containers Docker e práticas DevOps, compondo um ecossistema moderno e escalável.


---

> Desenvolvido como projeto de estudo e demonstração profissional.
