SELECT p.[Name], c.[Name]
FROM Products p
    LEFT JOIN ProductCategories pc 
        ON p.[Id] = pc.[ProductId]
    LEFT JOIN Categories c 
        ON c.[CategoryId] = pc.[Id];