void PlaySound(AudioClip clip)
{
    AudioSource audio = GetComponent<AudioSource>();
    audio.clip = clip;
    audio.Play();
}

void Jump()
{
    PlaySound(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot()
{
    PlaySound(shootSound);
    Instantiate(bullet);
}