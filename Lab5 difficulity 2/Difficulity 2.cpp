#include <iostream>
using std::cout;
using std::cin;
using std::endl;


int main() {
	int rows = 0, columns;
	int max_row = 0, max_column = 0;
	cout << "Please, enter the size of our square matrix" << endl;
	cin >> rows;
	columns = rows;

	//Объявление матрицы
	int** arr = new int* [rows];
	for (int i = 0; i < rows; i++) {
		arr[i] = new int[rows];
	}

	//Заполнение матрицы
	cout << "Please, fill the matrix" << endl;
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cin >> arr[i][j];
		}
	}

	//Поиск масимального элемента массива
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			if (arr[i][j] > arr[max_row][max_column]) {
				max_row = i;
				max_column = j;
			}
		}
	}

	//Удаление колонки особого элемента
	for (int i = 0; i < rows; i++) {
		for (int j = max_column; j < columns-1; j++) {
			arr[i][j] = arr[i][j + 1];
		}
	}
	columns--;

	//Удаление строки особого элемента
	if (max_row != rows-1) {
		arr[max_row] = arr[max_row + 1];
	}
	rows--;

	//Вывод матрицы
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cout << arr[i][j] << '\t';
		}
		cout << endl;
	}

	//Удаление матрицы
	for (int i = 0; i < rows; i++) {
		delete arr[i];
	}
	delete[] arr;

	return 0;
}