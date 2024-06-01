# SILVERPLATTER VENTURES Car Maintenance System

This project is a Windows application developed to assist SILVERPLATTER VENTURES in tracking the work done by workers, calculating their monthly gross salaries, and managing customer visits and discounts. The system stores information about workers, customers, work done by each worker, and consumable products. Reports generated from this data help the accounts manager, Mr. Brainy Trouble, analyze work done and calculate compensation.

## Table of Contents

- [Introduction](#introduction)
- [Problem Identification](#problem-identification)
- [System Analysis and Design](#system-analysis-and-design)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Database Schema](#database-schema)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

SILVERPLATTER VENTURES is a car maintenance company located in Tiana-Paga, Upper East Region of Ghana. This application aims to streamline the process of calculating worker salaries and customer discounts by tracking daily work and customer visits.

## Problem Identification

Mr. Brainy Trouble, the accounts manager, faces difficulties in calculating the gross salary of workers due to the variable nature of their allowances based on monthly work. Additionally, tracking customer visits manually to calculate discounts is cumbersome. The solution involves creating a database system to automate these processes.

## System Analysis and Design

The system is designed to:
- Track daily work done by each worker.
- Calculate monthly allowances based on the tracked work.
- Track customer visits to calculate applicable discounts.
- Store information about workers, customers, work, and consumable products.
- Generate reports for analysis to assist in calculating gross salaries and customer discounts.

### Entity-Relationship Diagram (ERD)

An ERD has been designed to illustrate the relationships between different entities in the system, such as Workers, Customers, Work, and Products.

## Features

- Track daily work done by workers.
- Calculate monthly allowances for workers.
- Track customer visits.
- Calculate customer discounts based on visit frequency.
- Generate reports for work done and customer visits.
- User-friendly Windows application interface.

## Technologies Used

- **Programming Language:** VB.NET
- **Database:** SQL Server
- **Reporting Tool:** Crystal Reports

## Database Schema

The system uses a SQL Server database with the following main tables:

- **Workers**: `worker_id`, `firstname`, `lastname`, `fixed_salary`, `role`
- **Customers**: `customer_id`, `firstname`, `lastname`, `total_visits`
- **Work**: `work_id`, `worker_id`, `date`, `description`, `allowance`
- **Products**: `product_id`, `name`, `price`, `quantity`



## Installation

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/quarshie-jay/Autoshop_management_system
    ```
   
2. **Set Up the Database:**
    - Create a new database in SQL Server.
    - Run the SQL script provided in the repository to create the necessary tables.

3. **Configure the Project:**
    - Open the project in Visual Studio.
    - Update the database connection string in the configuration file to match your SQL Server setup.

4. **Build and Run:**
    - Build the solution in Visual Studio.
    - Run the application.

## Usage

- **Track Work:** Enter daily work details for each worker.
- **Generate Reports:** Generate monthly reports to view the work done by each worker and calculate allowances.
- **Track Customers:** Enter customer visit details to calculate discounts.
- **Analyze Data:** Use Crystal Reports for detailed analysis and reporting.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any changes or enhancements.



## Contact

For any questions or suggestions, feel free to reach out to:

- **Email:** jamquar@gmail.com
- **GitHub:** https://github.com/quarshie-jay
