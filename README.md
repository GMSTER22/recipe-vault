Adrea Ferreira
# RecipeVault

RecipeVault is a .NET application designed to help you manage and organize your favorite recipes. With RecipeVault, you can easily store, search, and share your culinary creations.

## Features

- **Recipe Management**: Add, edit, and delete recipes with ease.
- **Sharing**: Share your recipes with the public for all to see.
- **Categorization**: Organize your recipes into categories for easy access.

## Contributors

- Anthon Brown
- Johnny Sanabria
- Gael Nongnogo
- Aaron Webster
- Alex Nielsen
- Linden Jensen
- Eli LeBlanc

## Getting Started

To get started with RecipeVault, follow these steps:

1. Clone the repository:
    ```sh
    git clone /home/aaron/dotnet/RecipeVault
    ```
2. Navigate to the project directory:
    ```sh
    cd RecipeVault
    ```
3. Build the project:
    ```sh
    dotnet build
    ```
4. udpate the connection string in appsettings.json:
5. Setup the database:
    ```sh
    dotnet ef database drop -f -v
    dotnet ef migrations add Initial
    dotnet ef database update
    ```
6. Run the application:
    ```sh
    dotnet run
    ```

## License

This project is licensed under the MIT License.

## Contact

For any questions or feedback, please contact the contributors.
