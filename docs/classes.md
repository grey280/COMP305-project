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

## Relationships
to-0..*: Rental

# Equipment
## Fields

## Relationships
to-0..*: Rental

# Rental
## Fields

## Relationships
to-1: Customer
to-1: Equipment