# HELLO WORLD MAIS COMPLEXO QUE VOCÊ JÁ VIU 😄

Este projeto demonstra um **Hello World** implementado com boas práticas de arquitetura moderna em **.NET**.

---

## 🚀 Tecnologias Utilizadas

- **.NET 8**
- **Docker**
- Arquitetura em camadas (**Domain**, **Infrastructure**, **Services**, **Worker**)
- Injeção de dependências com `IServiceCollection`

---

## ⚙️ Como Executar

1️⃣ **Build da imagem Docker**

```bash
docker build -t uv8-monitoracao-worker .
2️⃣ Executar o container

bash
Copiar
Editar
docker run --rm uv8-monitoracao-worker
Você verá a mensagem formatada no console.

💡 Sobre o Projeto
Mesmo sendo um simples Hello World, este exemplo serve como base para aplicações reais que sigam padrões de qualidade, separação de responsabilidades e preparação para produção com Docker.
