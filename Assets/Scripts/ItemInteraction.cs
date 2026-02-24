using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    // Fungsi ini terpanggil otomatis saat ada objek lain masuk ke area Trigger
    private void OnTriggerEnter(Collider other)
    {
        // Mengecek apakah objek yang menabrak memiliki Tag "Player"
        if (other.CompareTag("Player"))
        {
            // Menampilkan pesan di Console Unity untuk keperluan debug
            Debug.Log("Item berhasil diambil oleh: " + other.name);

            // Menghancurkan (menghapus) objek ini dari scene
            Destroy(gameObject);
        }
    }
}