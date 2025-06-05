CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),     -- Auto-incremented primary key
    UserName VARCHAR(50) NOT NULL UNIQUE,     -- Unique username, cannot be null
    Email VARCHAR(100) NOT NULL UNIQUE,       -- Email, must be unique and not null
    CreatedAt DATETIME DEFAULT GETDATE(),     -- Automatically set when user is created
    IsActive BIT DEFAULT 1                    -- Active status (1 = active, 0 = inactive)
);

INSERT INTO Users (UserName, Email, CreatedAt, IsActive)
VALUES 
('john_doe', 'john@example.com', GETDATE(), 1),
('jane_smith', 'jane@example.com', GETDATE(), 1),
('alice_1995', 'alice@example.com', GETDATE(), 1),
('bob_builder', 'bob@example.com', GETDATE(), 0),
('charlie_dev', 'charlie@example.com', GETDATE(), 1),
('diana_queen', 'diana@example.com', GETDATE(), 1),
('eric_zen', 'eric@example.com', GETDATE(), 1),
('franklin_t', 'franklin@example.com', GETDATE(), 0),
('grace_hopper', 'grace@example.com', GETDATE(), 1),
('harry_potter', 'harry@example.com', GETDATE(), 1);

select * from Users;
