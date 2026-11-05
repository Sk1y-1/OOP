```mermaid
classDiagram
    direction TB

    class Shape {
        <<abstract>>
        +int X1
        +int Y1
        +int X2
        +int Y2
        +Draw(Graphics g, bool rubber)*
    }

    class PointShape {
        +Draw(Graphics g, bool rubber)
    }

    class LineShape {
        +Draw(Graphics g, bool rubber)
    }

    class RectangleShape {
        +Draw(Graphics g, bool rubber)
    }

    class EllipseShape {
        +Draw(Graphics g, bool rubber)
    }

    Shape <|-- PointShape
    Shape <|-- LineShape
    Shape <|-- RectangleShape
    Shape <|-- EllipseShape
    ```
