# GemetricExtension

������������ ����� .NET Standart ����������, �������������� ���������������� ������� �������
�������������� ����� �� �� ���������� ����������.

� ������� ������ ��������������:
 * ������ ������� ����� �� ����������� �������� ��� �������
 * ������ ������� ������������ �� ���������� ������ ��� ������, ����������� ��-�� �� �����������
 �������������

���������� ������������ �������:
 * _GeometricExtension_ - ���� �������, ���������� ����������� � Nuget �����
 * _GeometricExtensionDemo_ - CLI ����������, ��������������� ������������� ����������
 * _Tests_ - ������, ���������� unit �����, ����������� ����������������, ���������� �� ����������

 �����������:
 * .NET Standart 2.0 ����������� SDK ��� ������ _GeometricExtension_
 * .NET 6.0 SDK ��� ������ _GeometricExtensionDemo_, _Tests_

 ������ ������������:
``` C#
using GeometricExtension.Services;
using GeometricExtension.Models;

// ������� ��������� ������� ����������
CalculationService _geometricService = new();

// ����������� ������� ������������, ��� 5, 6, 7 - ��� �������
CalculatedTriangle triangle = _geometricService.CalculateTriangleArea(5, 6, 7);

// ������ ����� ���������� �� �������
Console.WriteLine("������� ������������ ����������: {0}, ����������� {1}",
    triangle.FigureArea, triangle.IsRightTriangle ? "�������������" : "���������������");
```
