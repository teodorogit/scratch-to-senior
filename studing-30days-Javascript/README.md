# 📚 Roteiro de Estudos JavaScript - 30 Dias
**Duração:** 1 hora por dia  
**Nível:** Intermediário → Avançado

---

## 🎯 Semana 1: Intermediário - Fundamentos Sólidos

### Dia 1: Closures e Escopo Léxico
**Objetivo:** Dominar closures e entender o escopo em JavaScript

- **Teoria (20min):** O que são closures, como funcionam, cadeia de escopos
- **Prática (30min):** 
  - Criar funções que retornam funções
  - Implementar um contador privado usando closures
  - Criar factory functions
- **Desafio (10min):** Implementar um sistema de rate limiting usando closures

**Recursos:** MDN - Closures, JavaScript.info

---

### Dia 2: Funções de Ordem Superior
**Objetivo:** Dominar map, filter, reduce e criar suas próprias HOF

- **Teoria (15min):** Conceito de Higher Order Functions
- **Prática (35min):**
  - Manipular arrays com map/filter/reduce
  - Criar suas próprias versões de map e filter
  - Encadear métodos (chaining)
- **Desafio (10min):** Processar um array de produtos (filtrar, mapear, calcular total)

**Recursos:** Array methods documentation

---

### Dia 3: Promises e Async/Await
**Objetivo:** Entender programação assíncrona moderna

- **Teoria (20min):** Event loop, callbacks, promises, async/await
- **Prática (30min):**
  - Converter callbacks para promises
  - Usar async/await
  - Tratar erros com try/catch
  - Promise.all, Promise.race
- **Desafio (10min):** Criar uma função que busca dados de múltiplas APIs em paralelo

**Recursos:** JavaScript.info - Async

---

### Dia 4: Manipulação Avançada de Objetos
**Objetivo:** Object destructuring, spread, rest, métodos úteis

- **Teoria (15min):** ES6+ features para objetos
- **Prática (35min):**
  - Destructuring em parâmetros de funções
  - Spread operator para merge/clone
  - Object.keys(), Object.values(), Object.entries()
  - Optional chaining (?.) e nullish coalescing (??)
- **Desafio (10min):** Criar um sistema de merge profundo de objetos

**Recursos:** ES6 features guide

---

### Dia 5: Classes e Programação Orientada a Objetos
**Objetivo:** Entender classes, herança e encapsulamento em JS

- **Teoria (20min):** Classes, construtores, herança, métodos estáticos
- **Prática (30min):**
  - Criar classes com propriedades privadas (#)
  - Implementar herança com extends
  - Usar getters e setters
  - Métodos estáticos
- **Desafio (10min):** Criar um sistema de classes para um jogo (Player, Enemy, Boss)

**Recursos:** MDN - Classes

---

### Dia 6: Módulos ES6 e Organização de Código
**Objetivo:** Trabalhar com import/export e estruturar projetos

- **Teoria (15min):** CommonJS vs ES Modules, named vs default exports
- **Prática (35min):**
  - Criar módulos com export/import
  - Organizar código em arquivos separados
  - Usar import dinâmico
  - Configurar um projeto simples com módulos
- **Desafio (10min):** Refatorar um código monolítico em módulos organizados

**Recursos:** JavaScript modules guide

---

### Dia 7: Revisão e Projeto Semanal
**Objetivo:** Consolidar conhecimentos da semana

- **Revisão (20min):** Revisar conceitos da semana 1
- **Projeto (40min):** **Todo List Avançado**
  - Usar classes para gerenciar tarefas
  - Implementar filtros com HOF
  - Salvar no localStorage (async)
  - Organizar em módulos

---

## 🚀 Semana 2: Avançado - Padrões e Arquitetura

### Dia 8: Design Patterns - Singleton e Factory
**Objetivo:** Implementar padrões de criação

- **Teoria (20min):** O que são design patterns, quando usar
- **Prática (30min):**
  - Implementar Singleton Pattern
  - Implementar Factory Pattern
  - Comparar abordagens
- **Desafio (10min):** Criar um gerenciador de configuração global (Singleton)

**Recursos:** JavaScript Design Patterns

---

### Dia 9: Design Patterns - Observer e Module
**Objetivo:** Padrões comportamentais e estruturais

- **Teoria (20min):** Observer pattern (pub/sub), Module pattern
- **Prática (30min):**
  - Criar um event emitter customizado
  - Implementar pub/sub
  - Revealing Module Pattern
- **Desafio (10min):** Sistema de notificações com observer pattern

**Recursos:** Learning JavaScript Design Patterns (Addy Osmani)

---

### Dia 10: Imutabilidade e Programação Funcional
**Objetivo:** Escrever código funcional e imutável

- **Teoria (20min):** Princípios de FP, pure functions, imutabilidade
- **Prática (30min):**
  - Evitar mutações com spread/destructuring
  - Compose e pipe functions
  - Currying e partial application
- **Desafio (10min):** Criar funções utilitárias funcionais (compose, curry, memoize)

**Recursos:** Functional Programming in JavaScript

---

### Dia 11: Generators e Iterators
**Objetivo:** Entender iteração customizada e generators

- **Teoria (20min):** Symbol.iterator, generators (function*)
- **Prática (30min):**
  - Criar iterators customizados
  - Usar generators para sequências infinitas
  - Lazy evaluation
  - yield e yield*
- **Desafio (10min):** Generator para Fibonacci infinito e paginação

**Recursos:** MDN - Iterators and Generators

---

### Dia 12: Proxies e Reflect
**Objetivo:** Meta-programação em JavaScript

- **Teoria (20min):** Proxy handlers, Reflect API
- **Prática (30min):**
  - Interceptar operações em objetos
  - Validação com proxies
  - Observar mudanças em objetos
  - Usar Reflect para operações
- **Desafio (10min):** Criar um objeto reativo (como Vue.js básico)

**Recursos:** MDN - Proxy and Reflect

---

### Dia 13: WeakMap, WeakSet e Memory Management
**Objetivo:** Entender gerenciamento de memória

- **Teoria (20min):** Garbage collection, weak references
- **Prática (30min):**
  - Diferenças entre Map/WeakMap, Set/WeakSet
  - Casos de uso para WeakMap
  - Prevenir memory leaks
  - Usar WeakMap para dados privados
- **Desafio (10min):** Sistema de cache com expiração usando WeakMap

**Recursos:** JavaScript Memory Management

---

### Dia 14: Revisão e Projeto Semanal
**Objetivo:** Aplicar padrões aprendidos

- **Revisão (20min):** Revisar design patterns e conceitos avançados
- **Projeto (40min):** **Sistema de E-commerce Simples**
  - Usar Factory para criar produtos
  - Observer para carrinho de compras
  - Proxy para validação de estoque
  - Organização com padrões aprendidos

---

## ⚡ Semana 3: Avançado - Performance e Otimização

### Dia 15: Event Loop e Microtasks
**Objetivo:** Entender profundamente o event loop

- **Teoria (25min):** Call stack, task queue, microtask queue, requestAnimationFrame
- **Prática (25min):**
  - Experimentar com setTimeout vs Promise
  - queueMicrotask()
  - Ordem de execução
- **Desafio (10min):** Prever a ordem de execução de código assíncrono complexo

**Recursos:** Jake Archibald - Event Loop talk

---

### Dia 16: Performance e Otimização
**Objetivo:** Escrever código performático

- **Teoria (20min):** Debounce, throttle, memoization, lazy loading
- **Prática (30min):**
  - Implementar debounce e throttle
  - Criar função memoize
  - Otimizar loops e operações
  - Usar performance.now()
- **Desafio (10min):** Otimizar uma busca em tempo real com debounce

**Recursos:** Web Performance APIs

---

### Dia 17: Web Workers e Concorrência
**Objetivo:** Processamento em background

- **Teoria (20min):** Web Workers, Shared Workers, Service Workers básico
- **Prática (30min):**
  - Criar um Web Worker
  - Comunicação entre worker e main thread
  - Transferable objects
  - Casos de uso práticos
- **Desafio (10min):** Processar grandes arrays em worker sem travar a UI

**Recursos:** MDN - Web Workers API

---

### Dia 18: IndexedDB e Storage Avançado
**Objetivo:** Armazenamento client-side avançado

- **Teoria (20min):** IndexedDB API, comparação com localStorage
- **Prática (30min):**
  - CRUD operations no IndexedDB
  - Transações e índices
  - Versioning de database
  - Wrapper simplificado
- **Desafio (10min):** Criar um sistema de cache offline com IndexedDB

**Recursos:** Working with IndexedDB

---

### Dia 19: Streams API
**Objetivo:** Trabalhar com dados em fluxo

- **Teoria (20min):** ReadableStream, WritableStream, TransformStream
- **Prática (30min):**
  - Processar arquivos grandes em chunks
  - Fetch com streams
  - Criar streams customizados
  - Pipelines
- **Desafio (10min):** Upload de arquivo grande com progress e cancelamento

**Recursos:** Streams API Concepts

---

### Dia 20: Error Handling Avançado
**Objetivo:** Tratamento robusto de erros

- **Teoria (20min):** Custom errors, error boundaries, stack traces
- **Prática (30min):**
  - Criar classes de erro customizadas
  - Error handling strategies
  - Logging e monitoring
  - Graceful degradation
- **Desafio (10min):** Sistema de logging com diferentes níveis de severidade

**Recursos:** Error Handling Best Practices

---

### Dia 21: Revisão e Projeto Semanal
**Objetivo:** Aplicar otimizações e técnicas avançadas

- **Revisão (20min):** Revisar conceitos de performance
- **Projeto (40min):** **Dashboard com Dados em Tempo Real**
  - Usar Web Workers para processamento
  - Debounce em inputs
  - IndexedDB para cache
  - Error handling robusto

---

## 🎓 Semana 4: Avançado - Ferramentas e Ecossistema

### Dia 22: Testing - Unit Tests
**Objetivo:** Escrever testes unitários

- **Teoria (20min):** TDD, Jest básico, assertions
- **Prática (30min):**
  - Escrever testes com Jest
  - Mocks e spies
  - Coverage
  - Test-driven development
- **Desafio (10min):** Testar funções complexas criadas nas semanas anteriores

**Recursos:** Jest Documentation

---

### Dia 23: Testing - Integration e E2E
**Objetivo:** Testes de integração

- **Teoria (20min):** Diferença entre unit/integration/e2e
- **Prática (30min):**
  - Testes de integração
  - Mocking de APIs
  - Async testing
  - Snapshot testing
- **Desafio (10min):** Testar fluxo completo de uma feature

**Recursos:** Testing Best Practices

---

### Dia 24: TypeScript Fundamentals
**Objetivo:** Introdução ao TypeScript

- **Teoria (20min):** Por que TypeScript, tipos básicos, interfaces
- **Prática (30min):**
  - Configurar tsconfig.json
  - Anotar tipos em código existente
  - Criar interfaces e types
  - Generics básicos
- **Desafio (10min):** Converter projeto JS para TS

**Recursos:** TypeScript Handbook

---

### Dia 25: Build Tools e Bundlers
**Objetivo:** Entender Webpack, Vite, esbuild

- **Teoria (20min):** O que são bundlers, tree-shaking, code-splitting
- **Prática (30min):**
  - Configurar Vite básico
  - Criar build otimizado
  - Code splitting
  - Environment variables
- **Desafio (10min):** Otimizar bundle size de um projeto

**Recursos:** Vite Guide

---

### Dia 26: NPM e Package Management
**Objetivo:** Gerenciar dependências como profissional

- **Teoria (20min):** package.json, semantic versioning, npm vs yarn vs pnpm
- **Prática (30min):**
  - Criar e publicar um pacote NPM
  - Scripts npm
  - Gerenciar dependências
  - Lockfiles
- **Desafio (10min):** Criar um pacote utilitário e publicar no NPM

**Recursos:** NPM Documentation

---

### Dia 27: Security Best Practices
**Objetivo:** Escrever código seguro

- **Teoria (20min):** XSS, CSRF, injection attacks, CORS
- **Prática (30min):**
  - Sanitizar inputs
  - Content Security Policy
  - Secure storage
  - Validação de dados
- **Desafio (10min):** Auditar código para vulnerabilidades comuns

**Recursos:** OWASP Top 10

---

### Dia 28: RegExp Avançado
**Objetivo:** Dominar expressões regulares

- **Teoria (15min):** Regex patterns, flags, groups
- **Prática (35min):**
  - Validações complexas
  - Capture groups e lookaheads
  - Replace com funções
  - Performance de regex
- **Desafio (10min):** Criar validadores para email, CPF, telefone, etc.

**Recursos:** RegexOne, Regex101

---

### Dia 29: Projeto Final - Planejamento
**Objetivo:** Planejar aplicação completa

- **Planejamento (60min):**
  - Escolher projeto (sugestões abaixo)
  - Definir arquitetura
  - Listar features
  - Escolher tecnologias
  - Criar estrutura de pastas

**Sugestões de projeto:**
- App de finanças pessoais
- Sistema de gerenciamento de tarefas colaborativo
- Clone simplificado de rede social
- Dashboard analítico com gráficos

---

### Dia 30: Projeto Final - Implementação
**Objetivo:** Aplicar tudo que aprendeu

- **Desenvolvimento (60min):**
  - Implementar MVP do projeto
  - Aplicar padrões de design
  - Escrever testes
  - Otimizar performance
  - Documentar código

**Checklist:**
- ✅ Usa ES6+ features
- ✅ Design patterns aplicados
- ✅ Código modular e organizado
- ✅ Tratamento de erros
- ✅ Testes básicos
- ✅ Performance otimizada

---

## 📚 Recursos Complementares

### Documentação
- [MDN Web Docs](https://developer.mozilla.org/)
- [JavaScript.info](https://javascript.info/)
- [ECMAScript Specifications](https://tc39.es/ecma262/)

### Livros Recomendados
- "You Don't Know JS" - Kyle Simpson
- "Eloquent JavaScript" - Marijn Haverbeke
- "JavaScript: The Good Parts" - Douglas Crockford

### Prática
- [Exercism](https://exercism.org/tracks/javascript)
- [LeetCode](https://leetcode.com/)
- [Codewars](https://www.codewars.com/)

### Comunidades
- Stack Overflow
- Reddit r/javascript
- Discord JavaScript communities

---

## 💡 Dicas para Sucesso

1. **Consistência:** 1h por dia é melhor que 7h em um dia
2. **Pratique:** Teoria sem prática não fixa
3. **Projetos:** Crie projetos reais, não só tutoriais
4. **Leia código:** Estude código de bibliotecas famosas
5. **Ensine:** Explique conceitos para solidificar
6. **Revise:** Volte aos conceitos periodicamente
7. **Comunidade:** Participe de fóruns e grupos

---

## 🎯 Próximos Passos

Após completar este roteiro:
- Aprenda um framework (React, Vue, Angular)
- Estude Node.js para backend
- Aprofunde em TypeScript
- Contribua para projetos open source
- Construa um portfólio robusto

---

