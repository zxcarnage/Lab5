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

	//���������� �������
	int** arr = new int* [rows];
	for (int i = 0; i < rows; i++) {
		arr[i] = new int[rows];
	}

	//���������� �������
	cout << "Please, fill the matrix" << endl;
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cin >> arr[i][j];
		}
	}

	//����� �������
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cout << arr[i][j] << '\t';
		}
		cout << endl;
	}

	cout << endl;

	//����� ������������ �������� �������
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			if (arr[i][j] > arr[max_row][max_column]) {
				max_row = i;
				max_column = j;
			}
		}
	}

	//�������� ������� ������� ��������
	for (int i = 0; i < rows; i++) {
		for (int j = max_column; j < columns-1; j++) {
			arr[i][j] = arr[i][j + 1];
		}
	}
	columns--;

	//�������� ������ ������� ��������
	if (max_row != rows-1) {
		for (int i = max_row; i < rows-1; i++)
		{
			arr[i] = arr[i + 1];
		}
	}
	rows--;

	//����� �������
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			cout << arr[i][j] << '\t';
		}
		cout << endl;
	}

	//�������� �������
	for (int i = 0; i < rows; i++) {
		delete arr[i];
	}
	delete[] arr;

	return 0;
}