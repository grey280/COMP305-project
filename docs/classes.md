Classes.md: List of the classes that will be used. To be converted to class diagrams later.

# Employee
## Fields

## Relationships


# Technician: Employee
## Fields

## Relationships


# Manager: Employee
## Fields

## Relationships


# Executive: Manager
## Fields

## Relationships


# Customer
## Fields
name: String
contactPhone: String
contactEmail: String

## Relationships
to-0..*: Rental
to-0..*: Proposal
to-0..*: Order
to-0..*: Invoice

# Equipment
## Fields
name: String
modelNo: String
description: String
## Relationships
to-0..*: Rental

# Rental
## Fields
startDate: Date
endDate: Date
## Relationships
to-1: Customer
to-1: Equipment

# Proposal
## Fields

## Relationships
to-1: Customer
to-1: Order

# Order
## Fields

## Relationships
to-1: Proposal
to-1: Customer
to-1: Invoice

# Invoice
## Fields

## Relationships
to-1: Customer
to-1: Order