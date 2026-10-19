# Stack and Heap Diagrams

## 1. Creating an Order Object

Code:
    `Order order1 = new Order {OrderId = 1, CustomerName = "Ali"};`

### Diagram

```text
   STACK                                                          HEAP
                                                            _____________________________
                                                            |      Order Object          |
     _______                                                |                            |
    | order1| (referense) ----------------------->          |        OrderId = 1         |
    |_______|                                               |        CustomerName = "Ali |
                                                            |                            |
                                                            |____________________________|
```

## 2. Assigning order1 to order2

Code:
    `Order order2 = order1`

### Diagram

```text
    STACK                                                                  HEAP

    ________________
    |              |
    |   order1     |     ____________________________               __________________________
    |______________|                                 |              |                        |
                                                     |-------->     |   Order Object         |
                                                                    |     OrderId = 1        |
                                                     --------->     |     CustomerName= "Ali"|
    ________________                                 |              |________________________|
    |              |                                 |
    |   order1     |     ____________________________|
    |______________|                                 
                                                     
    
```

## 3. Modifying The Object Through order2

Code:
    `order2.IsPaid = true`

### Diagram

```text
    STACK                                                                  HEAP

    ________________
    |              |
    |   order1     |     ____________________________               __________________________
    |______________|                                 |              |                        |
                                                     |-------->     |   Order Object         |
                                                                    |     OrderId = 1        |
                                                     --------->     |     CustomerName= "Ali"|
                                                     |              |     IsPaid = true      |
    ________________                                 |              |________________________|
    |              |                                 |
    |   order1     |     ____________________________|
    |______________|                                 
                                                     
    
```

## 4. Structs and Value Types

Code:
    `Point p1 = new Point { X = 10, Y = 20};`
    `Point p2 = p1;`
    `p2.X = 99;`

### Diagram

```text
    STACK                                                                  HEAP

    ____________________
    |  p1              |
    |  X = 10, Y = 20  |
    |__________________|
                    
                                                     
    ____________________
    |  p2              |
    |  X = 99, Y = 20  |
    |__________________|
```
Explanation:
`Point` is a value type. 
Assigning `p1` to `p2` copies the struct's data, so each variable has its own copy.
Changing `p2.X` does not affect `p1.X`
