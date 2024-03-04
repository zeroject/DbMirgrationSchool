# Rollback plan for SQL

How to revert the ProductRatings table;

See V4_ROLLBACKForRatings_[script for removing ratings].

How to revert the Category table, and the foreign key references to the Products table.

See V5_ROLLBACKForRatings_[script for removing categories].

How to make the last rollback, that deletes the entire database:

DROP Database SchoolMigration;

