using Microsoft.AspNetCore.Mvc;
using tpmodul9_2311104059.Models;

namespace tpmodul9_2311104059.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "NamaAnda", Nim = "13022xxxxx" },
            new Mahasiswa { Nama = "Anggota2", Nim = "13022xxxxx" },
            new Mahasiswa { Nama = "Anggota3", Nim = "13022xxxxx" }
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(daftarMahasiswa);
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Data tidak ditemukan");
            return Ok(daftarMahasiswa[index]);
        }

        // POST /api/mahasiswa
        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Data tidak ditemukan");

            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}
