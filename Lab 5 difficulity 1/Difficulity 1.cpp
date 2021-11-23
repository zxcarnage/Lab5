#include <iostream>
using std::cout;
using std::cin;
using std::endl;


int main() {
	int rows = 0, columns = 0;
	bool positive = false, founded = false;
	cout << "Please,enter the size of matrix. First:rows, second columns" << endl;
	cin >> rows;
	cin >> columns;
	int** arr = new int* [rows];
	
	//Создание колонок массива
	for (int i = 0; i < rows; i++) {
		arr[i] = new int[columns];
	}

	//Заполнение матрицы
	cout << "Please, fill the matrix" << endl;
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cin >> arr[i][j];
		}
	}

	//Поиск строки без положительного элемента
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns && positive == false; j++) {
			if (arr[i][j] > 0) {
				positive = true;
			}
			else if (j == columns - 1) {
				cout << "The \"Special\" row is " << i + 1 << endl;
			}
		}
	}

	//Вывод матрицы
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cout << arr[i][j] << '\t';
		}
		cout << endl;
	}

	//Непосредственное удаление матрицы
	for (int i = 0; i < rows; i++) {
		delete arr[i];
	}
	delete[] arr;

	return 0;
}