# Employee Management System - Backend API

## Overview

This repository contains the backend implementation of the Employee Management System built using ASP.NET Core Web API, Entity Framework Core, and PostgreSQL.

The API provides complete CRUD operations for employee management and serves data to the Flutter mobile application.

## Features

* Create Employee
* View Employees
* Update Employee
* Delete Employee
* RESTful API Architecture
* Entity Framework Core Integration
* PostgreSQL Database Connectivity
* Middleware Request Logging
* Swagger API Documentation

## Tech Stack

* ASP.NET Core 8
* C#
* Entity Framework Core
* PostgreSQL
* Swagger/OpenAPI

## Project Structure

Controllers/
├── EmployeeController.cs

Models/
├── Employee.cs

Data/
├── AppDbContext.cs

Middleware/
├── RequestLoggingMiddleware.cs

Program.cs

## API Endpoints

### Get All Employees

GET /api/Employee

### Add Employee

POST /api/Employee

### Update Employee

PUT /api/Employee/{id}

### Delete Employee

DELETE /api/Employee/{id}

## Frontend Repository

Flutter Mobile Application:

👉 https://github.com/Shreya-khandelwal-0310/employee-management-flutter

## Architecture

Flutter App
↓
ASP.NET Core Web API
↓
Entity Framework Core
↓
PostgreSQL Database

## Learning Outcomes

* Building REST APIs using ASP.NET Core
* Database integration using Entity Framework Core
* CRUD operations implementation
* Middleware development
* API testing using Swagger
* Backend-Mobile integration

## Author

Shreya Khandelwal
