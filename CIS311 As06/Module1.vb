'------------------------------------------------------------
'-                File Name : Module1.vb                     - 
'-                Part of Project: As06
'------------------------------------------------------------
'-                Written By: Alex Buckstiegel              -
'-                Written On: 02-25-20                   -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the functions that do not requrie 
'- any form manipulation - its all the math functions 
'------------------------------------------------------------


Imports System.Math

Module Module1

    'Math functions!

    '------------------------------------------------------------
    '-                Subprogram Name: calcRectangleA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the area of a
    '– rectangle
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- L - Single for length
    '- W - Single for width
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Area of the rectangle           -
    '------------------------------------------------------------
    Public Function calcRectangleP(L As Single, W As Single)
        Return (2 * L) + (2 * W)
    End Function
    '------------------------------------------------------------
    '-                Subprogram Name: calcRectangleP            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the perimeter of a
    '– rectangle
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- L - Single for length
    '- W - Single for width
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Perimeter of the rectangle           -
    '------------------------------------------------------------
    Public Function calcRectangleA(L As Single, W As Single)
        Return L * W
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcSquareP           -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the perimeter of a
    '– square
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- S - Side length
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - perimeter of the square           -
    '------------------------------------------------------------
    Public Function calcSquareP(S As Single)
        Return S * 4
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcSquareA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the area of a
    '– square
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- S - For side length
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - area of the square
    '------------------------------------------------------------
    Public Function calcSquareA(S As Single)
        Return S ^ 2
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcTriangleP            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the perimeter of a
    '– Triangle
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- B - Single for base
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Perimeter of the Triangle
    '------------------------------------------------------------
    Public Function calcTriangleP(B As Single, H As Single)
        Return H + B + Sqrt(H ^ 2 + B ^ 2)
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcTriangleA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the are of a
    '– Triangle
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- B - Single for base
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - area of the Triangle
    '------------------------------------------------------------
    Public Function calcTriangleA(B As Single, H As Single)
        Return 0.5 * B * H
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcCircleC            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the circumfrence of a
    '– Triangle
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - single for radius
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - circumfrence of the circle
    '------------------------------------------------------------
    Public Function calcCircleC(R As Single)
        Return 2 * PI * R
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcCircleA              -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the area of a
    '– Triangle
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - single for radius
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - area of the circle
    '------------------------------------------------------------
    Public Function calcCircleA(R As Single)
        Return PI * R ^ 2
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcCubeSA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the surface area 
    '– of a cube
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- L - Single for length
    '- W - Single for width
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Surface area of the Cube
    '------------------------------------------------------------
    Public Function calcCubeSA(L As Single, W As Single, H As Single)
        Return (2 * L * W) + (2 * L * H) + (2 * W * H)
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcCubeV            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the volume
    '– of a cube
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- L - Single for length
    '- W - Single for width
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Volume of the Cube
    '------------------------------------------------------------
    Public Function calcCubeV(L As Single, W As Single, H As Single)
        Return L * W * H
    End Function
    '------------------------------------------------------------
    '-                Subprogram Name: calcSphereSA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the surface area 
    '– of a sphere
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - Single for radius
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Surface area of the Sphere
    '------------------------------------------------------------
    Public Function calcSphereSA(R As Single)
        Return 4 * PI * R ^ 2
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcSphereV            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the Volume
    '– of a sphere
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - Single for Radius
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Volume of the Sphere
    '------------------------------------------------------------
    Public Function calcSphereV(R As Single)
        Return (4 / 3) * PI * R ^ 3
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcCylindderSA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the surface area 
    '– of a cylinder
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - Single for radius
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Surface area of the Cylinder
    '------------------------------------------------------------
    Public Function calcCylinderSA(R As Single, H As Single)
        Return 2 * PI * R * H + 2 * PI * R ^ 2
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcCylindderV            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the Volume
    '– of a cylinder
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - Single for radius
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Volume of the Cylinder
    '------------------------------------------------------------
    Public Function calcCylinderV(R As Single, H As Single)
        Return PI * R ^ 2 * H
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcConeSA            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the surface area 
    '– of a cone
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - Single for radius
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - Surface area of the Cone
    '------------------------------------------------------------
    Public Function calcConeSA(R As Single, H As Single)
        Return (PI * R) * (R + Sqrt(R ^ 2 + H ^ 2))
    End Function

    '------------------------------------------------------------
    '-                Subprogram Name: calcConeV            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to caldculate the volume
    '– of a cone
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- R - Single for radius
    '- H - Single for height
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Single - volume of the Cone
    '------------------------------------------------------------
    Public Function calcConeV(R As Single, H As Single)
        Return (1 / 3) * PI * R ^ 2 * H
    End Function


End Module
