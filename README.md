# e-com API Documentation

This API is designed for an e-commerce application, providing functionalities for user authentication, product management, cart operations, payment processing, and shipment tracking. It utilizes ASP.NET Core, Entity Framework Core, and JWT for authentication.

## Getting Started

Ensure you have.NET 6.0 or later installed on your machine. Clone the repository and navigate to the project directory.

### Prerequisites

-.NET 6.0 or later
- SQL Server (for database)

### Installation

1. Open a terminal or command prompt.
2. Navigate to the project directory.
3. Run `dotnet restore` to restore dependencies.
4. Run `dotnet build` to build the project.
5. Run `dotnet run` to start the application.

## API Endpoints

### Authentication

- **POST /api/account/register**: Registers a new user.
- **POST /api/account/login**: Authenticates a user and returns a JWT token.

### Products

- **GET /api/products**: Retrieves all products.
- **GET /api/products/{id}**: Retrieves a product by ID.
- **POST /api/products**: Adds a new product.
- **PUT /api/products/{id}**: Updates an existing product.
- **DELETE /api/products/{id}**: Deletes a product by ID.

### Categories

- **GET /api/categories**: Retrieves all categories.
- **GET /api/categories/{id}**: Retrieves a category by ID.
- **POST /api/categories**: Adds a new category.
- **PUT /api/categories/{id}**: Updates an existing category.
- **DELETE /api/categories/{id}**: Deletes a category by ID.

### Cart

- **GET /api/cart**: Retrieves all items in the cart.
- **POST /api/cart**: Adds an item to the cart.
- **PUT /api/cart/{id}**: Updates an item in the cart.
- **DELETE /api/cart/{id}**: Removes an item from the cart.

### Payments

- **GET /api/payments**: Retrieves all payments.
- **GET /api/payments/{username}**: Retrieves payments by username.
- **POST /api/payments**: Adds a new payment.
- **PUT /api/payments/{id}**: Updates an existing payment.
- **DELETE /api/payments/{id}**: Deletes a payment by ID.

### Shipments

- **GET /api/shipments**: Retrieves all shipments.
- **GET /api/shipments/{username}**: Retrieves shipments by username.
- **POST /api/shipments**: Adds a new shipment.
- **PUT /api/shipments/{id}**: Updates an existing shipment.
- **DELETE /api/shipments/{id}**: Deletes a shipment by ID.

### Wish List

- **GET /api/wishlist**: Retrieves all items in the wishlist.
- **GET /api/wishlist/{id}**: Retrieves a wishlist item by ID.
- **POST /api/wishlist**: Adds an item to the wishlist.
- **PUT /api/wishlist/{id}**: Updates an item in the wishlist.
- **DELETE /api/wishlist/{id}**: Removes an item from the wishlist.

## Security

The API uses JWT for authentication. Ensure to include the JWT token in the `Authorization` header for protected endpoints.

## License

This project is licensed under the MIT License.

## Contact

For any questions or issues, please open an issue on the GitHub repository.
