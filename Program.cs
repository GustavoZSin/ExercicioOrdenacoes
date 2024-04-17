using TesteOrdenacao;

//Gera as listas originais e as exibe
Gerador gerador = new();
Console.WriteLine("Gerando Listas Originais...");
ListaDuplamenteEncadeada listaInversamenteOrdenada = gerador.GerarListaInversamenteOrdenada();
ListaDuplamenteEncadeada listaDesordenada = gerador.GerarListaDesordenada();
ListaDuplamenteEncadeada listaOrdenada = gerador.GerarListaOrdenada();
Console.WriteLine("------------------------");

#region Bubble Sort
ListaDuplamenteEncadeada lBubbleSortOrdenada1 = Ordenador.BubbleSort(listaOrdenada);
Ordenador.Exibir("Lista Ordenada:", lBubbleSortOrdenada1, "Bubble Sort:\n");

ListaDuplamenteEncadeada lBubbleSortOrdenada2 = Ordenador.BubbleSort(listaDesordenada);
Ordenador.Exibir("Lista Desordenada:", lBubbleSortOrdenada2);

ListaDuplamenteEncadeada lBubbleSortOrdenada3 = Ordenador.BubbleSort(listaInversamenteOrdenada);
Ordenador.Exibir("Lista Inversamente Ordenada:", lBubbleSortOrdenada3);
#endregion

#region Selection Sort
ListaDuplamenteEncadeada lSelectionSortOrdenada1 = Ordenador.SelectionSort(listaOrdenada);
Ordenador.Exibir("Lista Ordenada:", lSelectionSortOrdenada1, "\nSelection Sort:\n");

ListaDuplamenteEncadeada lSelectionSortOrdenada2 = Ordenador.SelectionSort(listaDesordenada);
Ordenador.Exibir("Lista Desordenada:", lSelectionSortOrdenada2);

ListaDuplamenteEncadeada lSelectionSortOrdenada3 = Ordenador.SelectionSort(listaInversamenteOrdenada);
Ordenador.Exibir("Lista Inversamente Ordenada:", lSelectionSortOrdenada3);
#endregion

#region Insertion Sort
ListaDuplamenteEncadeada lInsertionSortOrdenada1 = Ordenador.InsertionSort(listaOrdenada);
Ordenador.Exibir("Lista Ordenada:", lInsertionSortOrdenada1, "\nInsertion Sort:\n");

ListaDuplamenteEncadeada lInsertionSortOrdenada2 = Ordenador.InsertionSort(listaDesordenada);
Ordenador.Exibir("Lista Desordenada:", lInsertionSortOrdenada2);

ListaDuplamenteEncadeada lInsertionSortOrdenada3 = Ordenador.InsertionSort(listaInversamenteOrdenada);
Ordenador.Exibir("Lista Inversamente Ordenada:", lInsertionSortOrdenada3);
#endregion

#region Merge Sort
ListaDuplamenteEncadeada lMergeSortOrdenada1 = Ordenador.MergeSort(listaOrdenada);
Ordenador.Exibir("Lista Ordenada:", lMergeSortOrdenada1, "\nMerge Sort:\n");

ListaDuplamenteEncadeada lMergeSortOrdenada2 = Ordenador.MergeSort(listaDesordenada);
Ordenador.Exibir("Lista Desordenada:", lMergeSortOrdenada2);

ListaDuplamenteEncadeada lMergeSortOrdenada3 = Ordenador.MergeSort(listaInversamenteOrdenada);
Ordenador.Exibir("Lista Inversamente Ordenada:", lMergeSortOrdenada3);
#endregion

#region Quick Sort
ListaDuplamenteEncadeada lQuickSortOrdenada1 = Ordenador.QuickSort(listaOrdenada);
Ordenador.Exibir("Lista Ordenada:", lQuickSortOrdenada1, "\nQuick Sort:\n");

ListaDuplamenteEncadeada lQuickSortOrdenada2 = Ordenador.QuickSort(listaDesordenada);
Ordenador.Exibir("Lista Desordenada:", lQuickSortOrdenada2);

ListaDuplamenteEncadeada lQuickSortOrdenada3 = Ordenador.QuickSort(listaInversamenteOrdenada);
Ordenador.Exibir("Lista Inversamente Ordenada:", lQuickSortOrdenada3);
#endregion

#region Tree Sort
ListaDuplamenteEncadeada lTreeSortOrdenada1 = Ordenador.TreeSort(listaOrdenada);
Ordenador.Exibir("Lista Ordenada:", lTreeSortOrdenada1, "\nTree Sort:\n");

ListaDuplamenteEncadeada lTreeSortOrdenada2 = Ordenador.TreeSort(listaDesordenada);
Ordenador.Exibir("Lista Desordenada:", lTreeSortOrdenada2);

ListaDuplamenteEncadeada lTreeSortOrdenada3 = Ordenador.TreeSort(listaInversamenteOrdenada);
Ordenador.Exibir("Lista Inversamente Ordenada:", lTreeSortOrdenada3);
#endregion