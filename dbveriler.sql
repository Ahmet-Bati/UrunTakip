PGDMP     2                    {         	   dbveriler    15.3    15.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16398 	   dbveriler    DATABASE     }   CREATE DATABASE dbveriler WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE dbveriler;
                postgres    false            �            1259    16481    doviz    TABLE     c   CREATE TABLE public.doviz (
    id integer NOT NULL,
    dolar numeric,
    dolarkurtarihi date
);
    DROP TABLE public.doviz;
       public         heap    postgres    false            �            1259    16480    doviz_id_seq    SEQUENCE     �   ALTER TABLE public.doviz ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.doviz_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    16409    satilanurunler    TABLE       CREATE TABLE public.satilanurunler (
    id bigint NOT NULL,
    barkod text NOT NULL,
    urunadi text NOT NULL,
    alisdolar numeric(10,1) NOT NULL,
    satisdolar numeric(10,1) NOT NULL,
    satistl numeric(10,1) NOT NULL,
    satistarihi date NOT NULL
);
 "   DROP TABLE public.satilanurunler;
       public         heap    postgres    false            �            1259    16408    satilan_urunler_id_seq    SEQUENCE        CREATE SEQUENCE public.satilan_urunler_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.satilan_urunler_id_seq;
       public          postgres    false    217                       0    0    satilan_urunler_id_seq    SEQUENCE OWNED BY     P   ALTER SEQUENCE public.satilan_urunler_id_seq OWNED BY public.satilanurunler.id;
          public          postgres    false    216            �            1259    16400    urunler    TABLE     �   CREATE TABLE public.urunler (
    urunid bigint NOT NULL,
    barkod text NOT NULL,
    urunadi text NOT NULL,
    alisdolar numeric NOT NULL,
    satisdolar numeric NOT NULL,
    urunstok integer NOT NULL,
    alistarihi date NOT NULL
);
    DROP TABLE public.urunler;
       public         heap    postgres    false            �            1259    16399    urunler_urun_id_seq    SEQUENCE     |   CREATE SEQUENCE public.urunler_urun_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.urunler_urun_id_seq;
       public          postgres    false    215                       0    0    urunler_urun_id_seq    SEQUENCE OWNED BY     J   ALTER SEQUENCE public.urunler_urun_id_seq OWNED BY public.urunler.urunid;
          public          postgres    false    214            p           2604    16412    satilanurunler id    DEFAULT     w   ALTER TABLE ONLY public.satilanurunler ALTER COLUMN id SET DEFAULT nextval('public.satilan_urunler_id_seq'::regclass);
 @   ALTER TABLE public.satilanurunler ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217            o           2604    16403    urunler urunid    DEFAULT     q   ALTER TABLE ONLY public.urunler ALTER COLUMN urunid SET DEFAULT nextval('public.urunler_urun_id_seq'::regclass);
 =   ALTER TABLE public.urunler ALTER COLUMN urunid DROP DEFAULT;
       public          postgres    false    215    214    215            
          0    16481    doviz 
   TABLE DATA           :   COPY public.doviz (id, dolar, dolarkurtarihi) FROM stdin;
    public          postgres    false    219   �                 0    16409    satilanurunler 
   TABLE DATA           j   COPY public.satilanurunler (id, barkod, urunadi, alisdolar, satisdolar, satistl, satistarihi) FROM stdin;
    public          postgres    false    217   �                 0    16400    urunler 
   TABLE DATA           g   COPY public.urunler (urunid, barkod, urunadi, alisdolar, satisdolar, urunstok, alistarihi) FROM stdin;
    public          postgres    false    215                     0    0    doviz_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.doviz_id_seq', 17, true);
          public          postgres    false    218                       0    0    satilan_urunler_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.satilan_urunler_id_seq', 102, true);
          public          postgres    false    216                       0    0    urunler_urun_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.urunler_urun_id_seq', 57, true);
          public          postgres    false    214            v           2606    16487    doviz doviz_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.doviz
    ADD CONSTRAINT doviz_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.doviz DROP CONSTRAINT doviz_pkey;
       public            postgres    false    219            t           2606    16416 #   satilanurunler satilan_urunler_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.satilanurunler
    ADD CONSTRAINT satilan_urunler_pkey PRIMARY KEY (id);
 M   ALTER TABLE ONLY public.satilanurunler DROP CONSTRAINT satilan_urunler_pkey;
       public            postgres    false    217            r           2606    16407    urunler urunler_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT urunler_pkey PRIMARY KEY (urunid);
 >   ALTER TABLE ONLY public.urunler DROP CONSTRAINT urunler_pkey;
       public            postgres    false    215            
   #   x�34�42�345��4202�5��52����� B��           x���Aj�0E��)t���F�9C0������M N���r�ʔRJۅ=��??���"IDpM;��x�O㹛�yv���"q-.@��.�*���r�$������m�ߌ����ۗ��B��\���lf��l`�!��l�A���}4��� �#�jƲ9���mӾ���6�o��.{s�雥J>�9�p��/���6rِ����Ub r����G�aM��*X��=j����5TI������ʪ��G���r>������ �Ҡ           x�e�Mn�0���S� {�������n�q�4*H$z���܁ޫC�槱eɋ���f�s�����=�,��he|Z�Yķ���2o�C/7q���@�~ѐ �aEfZ�7ZA�<4{��e[�#G���0N#Aq�I._�/}W���8�.�|�^�N-��-�S[��+�-k�|�y��f��e��{�Vg�(��<"�A��[��D�y1nSJ�9V� ��dT���O�ᦳ��+������΂Y���6@������^=�B�nf     