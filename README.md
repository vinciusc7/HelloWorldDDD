📘 README
Hello World mais complexo que você já viu 😄
Este projeto demonstra um Hello World implementado com boas práticas de arquitetura moderna em .NET:

✅ DDD (Domain-Driven Design)
✅ Princípios SOLID
✅ Injeção de Dependência
✅ Containerização com Docker

Tudo orquestrado de ponta a ponta, desde o Domain até a execução no Docker.

🚀 Tecnologias Utilizadas
.NET 8

Docker

Arquitetura em camadas (Domain, Infrastructure, Services, Worker)

Injeção de dependências com IServiceCollection

⚙️ Como executar
1️⃣ Build da imagem Docker

bash
Copiar
Editar
docker build -t uv8-monitoracao-worker .
2️⃣ Executar o container

bash
Copiar
Editar
docker run --rm uv8-monitoracao-worker
Você verá a mensagem formatada no console.

💡 Sobre o projeto
Mesmo sendo um simples Hello World, este exemplo serve como base para aplicações reais que sigam padrões de qualidade, separação de responsabilidades e preparação para produção com Docker.

