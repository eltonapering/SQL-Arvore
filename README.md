## Tarefa 2 - Lógica da Árvore

Foi escrito usando uma aplicação console App, conforme código disponilizado na pasta ArvoreBinariaRaizMaxima.

## Tarefa 1 - Consulta de Salário Máximo por Departamento

```sql
SELECT d.Nome as Departamento, p.Nome as Pessoa, p.Salario
FROM Pessoa p
INNER JOIN Departamento d ON p.DeptId = d.Id
WHERE p.Salario IN (
    SELECT MAX(Salario)
    FROM Pessoa
    GROUP BY DeptId
);
```

Segue abaixo estrutura das tabelas utilizadas:

## Estrutura do Banco de Dados

O banco de dados consiste em duas tabelas:

- `Departamento`: Armazena informações sobre os departamentos da empresa.
- `Pessoa`: Contém os dados dos colaboradores, incluindo o salário e a relação com o departamento ao qual pertencem.

### Tabela Departamento

| Campo | Tipo         | Descrição             |
|-------|--------------|-----------------------|
| Id    | INT          | ID do departamento    |
| Nome  | VARCHAR(255) | Nome do departamento  |

### Tabela Pessoa

| Campo   | Tipo           | Descrição                       |
|---------|----------------|---------------------------------|
| Id      | INT            | ID da pessoa                    |
| Nome    | VARCHAR(255)   | Nome da pessoa                  |
| Salario | DECIMAL(10, 2) | Salário da pessoa               |
| DeptId  | INT            | ID do departamento relacionado  |

## Instruções DDL

Para criar as tabelas no banco de dados, utilizamos as seguintes instruções DDL:

```sql
CREATE TABLE Departamento (
    Id INT PRIMARY KEY,
    Nome VARCHAR(255)
);

CREATE TABLE Pessoa (
    Id INT PRIMARY KEY,
    Nome VARCHAR(255),
    Salario DECIMAL(10, 2),
    DeptId INT,
    FOREIGN KEY (DeptId) REFERENCES Departamento(Id)
); 
```


## Instruções DML

```sql
INSERT INTO Departamento (Id, Nome) VALUES (1, 'TI'), (2, 'Vendas');

INSERT INTO Pessoa (Id, Nome, Salario, DeptId) VALUES
(1, 'Joe', 70000, 1),
(2, 'Henry', 80000, 2),
(3, 'Sam', 60000, 2),
(4, 'Max', 90000, 1);
```

