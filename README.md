<h1 align="center">🚗 Sistema de Gerenciamento de Estacionamento</h1>

<p align="center">
  <img src="https://images.unsplash.com/photo-1590674899484-d5640e854abe?w=800&h=400&fit=crop" alt="Estacionamento" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Version%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/Status-Concluído-success?style=for-the-badge" alt="Status"/>
</p>

## 📋 Sobre o Projeto

Sistema completo de gerenciamento de estacionamento desenvolvido em C# como parte do desafio de fundamentos da **Trilha .NET da DIO**. A aplicação permite controlar a entrada e saída de veículos, calculando automaticamente o valor a ser cobrado com base no tempo de permanência.

## ✨ Funcionalidades

- ✅ **Cadastrar Veículo**: Registra a placa de um veículo no estacionamento
- ✅ **Remover Veículo**: Remove o veículo e calcula o valor total com base no tempo de permanência
- ✅ **Listar Veículos**: Exibe todos os veículos atualmente estacionados
- ✅ **Cálculo Automático**: Calcula o valor cobrado (preço inicial + preço por hora × horas)
- ✅ **Interface Interativa**: Menu em console com navegação intuitiva

## 🛠️ Tecnologias Utilizadas

- **C# 10**
- **.NET  8.0**
- **Programação Orientada a Objetos**
- **Collections (List<T>)**
- **LINQ**

## 📐 Arquitetura

O projeto segue uma estrutura organizada com separação de responsabilidades:

```
DesafioFundamentos/
├── Models/
│   └── Estacionamento.cs    # Classe principal com lógica de negócio
├── Program.cs               # Ponto de entrada e interface com usuário
└── DesafioFundamentos.csproj
```

### Classe Estacionamento

**Propriedades:**
- `PricingStart` (decimal): Preço inicial cobrado ao estacionar
- `PricingByHour` (decimal): Valor cobrado por hora
- `Vehicles` (List<string>): Lista de placas dos veículos estacionados

**Métodos:**
- `AdicionarVeiculo()`: Adiciona um novo veículo ao estacionamento
- `RemoverVeiculo()`: Remove o veículo e calcula o valor total
- `ListarVehicles()`: Lista todos os veículos estacionados

## 🚀 Como Executar

### Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download) ou superior

### Passos

1. Clone o repositório
```bash
git clone https://github.com/seu-usuario/trilha-net-fundamentos-desafio.git
```

2. Navegue até a pasta do projeto
```bash
cd trilha-net-fundamentos-desafio/DesafioFundamentos
```

3. Execute o projeto
```bash
dotnet run
```

## 💡 Como Usar

1. Ao iniciar, informe o **preço inicial** do estacionamento
2. Em seguida, informe o **preço por hora**
3. Utilize o menu para:
   - **Opção 1**: Cadastrar um veículo (digite a placa)
   - **Opção 2**: Remover um veículo (informe placa e horas estacionadas)
   - **Opção 3**: Listar todos os veículos
   - **Opção 4**: Encerrar o sistema

### Exemplo de Uso

```
Seja bem vindo ao sistema de estacionamento!
Digite o preço inicial:
5.00
Agora digite o preço por hora:
2.50

Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
> 1

Digite a placa do veículo para estacionar:
ABC-1234
```

## 📊 Cálculo do Valor

O valor total cobrado é calculado pela fórmula:

```
Valor Total = Preço Inicial + (Preço por Hora × Horas Estacionadas)
```

**Exemplo:**
- Preço inicial: R$ 5,00
- Preço por hora: R$ 2,50
- Tempo estacionado: 3 horas
- **Total: R$ 12,50** (5,00 + 2,50 × 3)

## 🎯 Aprendizados

Este projeto demonstra conhecimentos em:

- ✔️ Fundamentos de C# e .NET
- ✔️ Programação Orientada a Objetos (POO)
- ✔️ Encapsulamento e propriedades
- ✔️ Manipulação de coleções (List)
- ✔️ Estruturas de controle (loops, switch)
- ✔️ Entrada e saída de dados no console
- ✔️ Tratamento de strings e formatação

## 👨‍💻 Desenvolvedor

Desenvolvido com 💙 como parte da **Trilha .NET - DIO (Digital Innovation One)**

---

<p align="center">
  Feito com ☕ e muito código!
</p>
