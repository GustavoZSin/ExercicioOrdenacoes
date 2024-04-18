using TesteOrdenacao;

//Gera as listas originais e as exibe
Gerador gerador = new(10);
Console.WriteLine("Gerando Listas Originais...");
ListaDuplamenteEncadeada listaInversamenteOrdenada = gerador.GerarListaInversamenteOrdenada();
ListaDuplamenteEncadeada listaDesordenada = gerador.GerarListaDesordenada();
ListaDuplamenteEncadeada listaOrdenada = gerador.GerarListaOrdenada();
Console.WriteLine("------------------------");

#region Bubble Sort
ListaDuplamenteEncadeada lBubbleSortOrdenada1 = Ordenador.BubbleSort(listaOrdenada.Copiar());
Ordenador.Exibir("Lista Ordenada:", lBubbleSortOrdenada1, "Bubble Sort:\n");

ListaDuplamenteEncadeada lBubbleSortOrdenada2 = Ordenador.BubbleSort(listaDesordenada.Copiar());
Ordenador.Exibir("Lista Desordenada:", lBubbleSortOrdenada2);

ListaDuplamenteEncadeada lBubbleSortOrdenada3 = Ordenador.BubbleSort(listaInversamenteOrdenada.Copiar());
Ordenador.Exibir("Lista Inversamente Ordenada:", lBubbleSortOrdenada3);
#endregion

#region Selection Sort
ListaDuplamenteEncadeada lSelectionSortOrdenada1 = Ordenador.SelectionSort(listaOrdenada.Copiar());
Ordenador.Exibir("Lista Ordenada:", lSelectionSortOrdenada1, "\nSelection Sort:\n");

ListaDuplamenteEncadeada lSelectionSortOrdenada2 = Ordenador.SelectionSort(listaDesordenada.Copiar());
Ordenador.Exibir("Lista Desordenada:", lSelectionSortOrdenada2);

ListaDuplamenteEncadeada lSelectionSortOrdenada3 = Ordenador.SelectionSort(listaInversamenteOrdenada.Copiar());
Ordenador.Exibir("Lista Inversamente Ordenada:", lSelectionSortOrdenada3);
#endregion

#region Insertion Sort
ListaDuplamenteEncadeada lInsertionSortOrdenada1 = Ordenador.InsertionSort(listaOrdenada.Copiar());
Ordenador.Exibir("Lista Ordenada:", lInsertionSortOrdenada1, "\nInsertion Sort:\n");

ListaDuplamenteEncadeada lInsertionSortOrdenada2 = Ordenador.InsertionSort(listaDesordenada.Copiar());
Ordenador.Exibir("Lista Desordenada:", lInsertionSortOrdenada2);

ListaDuplamenteEncadeada lInsertionSortOrdenada3 = Ordenador.InsertionSort(listaInversamenteOrdenada.Copiar());
Ordenador.Exibir("Lista Inversamente Ordenada:", lInsertionSortOrdenada3);
#endregion

#region Merge Sort
ListaDuplamenteEncadeada lMergeSortOrdenada1 = Ordenador.MergeSort(listaOrdenada.Copiar());
Ordenador.Exibir("Lista Ordenada:", lMergeSortOrdenada1, "\nMerge Sort:\n");

ListaDuplamenteEncadeada lMergeSortOrdenada2 = Ordenador.MergeSort(listaDesordenada.Copiar());
Ordenador.Exibir("Lista Desordenada:", lMergeSortOrdenada2);

ListaDuplamenteEncadeada lMergeSortOrdenada3 = Ordenador.MergeSort(listaInversamenteOrdenada.Copiar());
Ordenador.Exibir("Lista Inversamente Ordenada:", lMergeSortOrdenada3);
#endregion

#region Quick Sort
ListaDuplamenteEncadeada lQuickSortOrdenada1 = Ordenador.QuickSort(listaOrdenada.Copiar());
Ordenador.Exibir("Lista Ordenada:", lQuickSortOrdenada1, "\nQuick Sort:\n");

ListaDuplamenteEncadeada lQuickSortOrdenada2 = Ordenador.QuickSort(listaDesordenada.Copiar());
Ordenador.Exibir("Lista Desordenada:", lQuickSortOrdenada2);

ListaDuplamenteEncadeada lQuickSortOrdenada3 = Ordenador.QuickSort(listaInversamenteOrdenada.Copiar());
Ordenador.Exibir("Lista Inversamente Ordenada:", lQuickSortOrdenada3);
#endregion

#region Tree Sort
ListaDuplamenteEncadeada lTreeSortOrdenada1 = Ordenador.TreeSort(listaOrdenada.Copiar());
Ordenador.Exibir("Lista Ordenada:", lTreeSortOrdenada1, "\nTree Sort:\n");

ListaDuplamenteEncadeada lTreeSortOrdenada2 = Ordenador.TreeSort(listaDesordenada.Copiar());
Ordenador.Exibir("Lista Desordenada:", lTreeSortOrdenada2);

ListaDuplamenteEncadeada lTreeSortOrdenada3 = Ordenador.TreeSort(listaInversamenteOrdenada.Copiar());
Ordenador.Exibir("Lista Inversamente Ordenada:", lTreeSortOrdenada3);
#endregion