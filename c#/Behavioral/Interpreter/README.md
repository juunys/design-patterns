# Interpreter
Defines a representation for your grammar along with an interpreter that uses the representation to interpret sentences in the language

## When To Use
- Grammar for simple
- Efficiency is not a critical concern

## Context
Class that contains data that we want to interpret

## AbstractExpression
Uses the context object as param. Context object contains data that we want to interpret

## NonTerminalExpression
Elements that will be replaced during avaliation, as variables or rules

## TerminalExpression
Grammar elements that cannot be replaced, such as symbols

## Client
Builds the abstract syntax tree for a set of statements in the given grammar