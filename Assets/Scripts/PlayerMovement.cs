using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variabel kecepatan yang bisa diubah melalui Inspector Unity
    [SerializeField] private float speed = 5.0f;

    void Update()
    {
        // 1. Mengambil Input (Horizontal: A/D atau Panah Kiri/Kanan, Vertical: W/S atau Panah Atas/Bawah)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 2. Menentukan arah pergerakan dalam ruang 3D (X, Y, Z)
        // Kita biarkan Y tetap 0 agar karakter tidak terbang
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        // 3. Normalisasi agar kecepatan saat gerak diagonal tidak lebih cepat
        if (direction.magnitude > 1) {
            direction.Normalize();
        }

        // 4. Menggerakkan objek
        // Time.deltaTime digunakan agar kecepatan gerakan konsisten di semua FPS
        transform.Translate(direction * speed * Time.deltaTime);
    }
}