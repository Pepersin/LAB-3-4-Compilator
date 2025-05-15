# Объявления перечисления на языке PHP

## Вариант 44: Объявление и определение структуры

```rust
enum Suit
{
   case Hearts;
   case Diamonds;
   case Clubs;
   case Spades;
};
```

## Разработанная грамматика

```
Продукции P:
1) ⟨Def⟩ → "enum " ⟨Enum⟩
2) ⟨Enum⟩ → ⟨Name⟩ ' ' '{' ⟨Body⟩
3) ⟨Body⟩ → 'case ' ⟨Name⟩ ';' ⟨CaseRem⟩
4) ⟨CaseRem⟩ → 'case ' ⟨Name⟩ ';' ⟨CaseRem⟩
5) ⟨CaseRem⟩ → '}' ⟨End⟩
6) ⟨End⟩ → ';'
Разбор имени
7) ⟨Name⟩ → ⟨Letter⟩ ⟨NameRem⟩
8) ⟨NameRem⟩ → ⟨Letter⟩ ⟨NameRem⟩
9) ⟨NameRem⟩ → ⟨Digit⟩ ⟨NameRem⟩
10) ⟨NameRem⟩ → ε
Алфавит:
11) ⟨Letter⟩ → "a" | "b" | ... | "z" | "A" | ... | "Z"
12) ⟨Digit⟩ → "0" | "1" | ... | "9"
```


## Классификация грамматики

Согласно классификации Хомского, данная грамматика:

- Класс 2 (контекстно-свободная грамматика)
- (A → α), где А- один нетерминал, а α- произвольная строка из терминалов и/или нетерминалов. 


## Граф конечного автомата

![Диаграмма конечного автомата]![image](https://github.com/user-attachments/assets/6cb8cc12-ecbb-414f-9bb3-a385144e9d47)


## Тестовые примеры

### Корректный ввод

![Пример корректной структуры]![image](https://github.com/user-attachments/assets/b89b49fb-7e86-4752-ae5b-f1ccfebd3e1c)

### Ошибочный ввод

![Пример вывода ошибок] ![image](https://github.com/user-attachments/assets/6faf2fef-4acb-40ef-a58f-2dc6ba4f7f79)

