S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMF4
Build-Date: 2013.06.25 21:23:12

Crash Information
Process Name: MyHondana
PID: 10280
Date: 2013-07-01 15:26:08(GMT+0900)
Executable File Path: /opt/apps/vMEuS5j7iC/bin/MyHondana
This process is multi-thread process
pid=10280 tid=10280
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10280, uid 5000)
      TIMER: -2

Register Information
r0   = 0x00000000, r1   = 0xbe88a928
r2   = 0x00000001, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xbe88a928
r6   = 0x000002d0, r7   = 0x00000001
r8   = 0x00000000, r9   = 0xbe88aac4
r10  = 0x00000001, fp   = 0xbe88a970
ip   = 0xb3e04531, sp   = 0xbe88a788
lr   = 0xb3e04543, pc   = 0xb3e0f1f0
cpsr = 0x680f0030

Memory Information
MemTotal:  2063912 KB
MemFree:   1379688 KB
Buffers:     30196 KB
Cached:     339124 KB
VmPeak:     121540 KB
VmSize:     117420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27440 KB
VmRSS:       27440 KB
VmData:      17108 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       65980 KB
VmPTE:          98 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00070000 rw-p [heap]
00070000 00278000 rw-p [heap]
b064f000 b0653000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b065c000 b0e5b000 rwxp [stack:10282]
b0e5b000 b0fa9000 r-xp /usr/lib/r3p2/libMali.so
b0fb5000 b0fdd000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0fe1000 b0fff000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b1011000 b1017000 r-xp /usr/lib/libUMP.so
b1358000 b13a4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b13ad000 b13b2000 r-xp /usr/lib/libjson.so.0.0.1
b13ba000 b13be000 r-xp /usr/lib/liblocation-pos-log.so
b13c6000 b13d1000 r-xp /usr/lib/libmdm-common.so.1.0.37
b13d9000 b13eb000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b13f3000 b13f5000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b13fd000 b1402000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b140a000 b1415000 r-xp /usr/lib/libdrm-trusted.so.0.0.51
b141d000 b141f000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1427000 b1434000 r-xp /usr/lib/libdrm-client.so.0.0.90
b143d000 b1445000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b1467000 b149e000 r-xp /usr/lib/libpulse.so.0.16.2
b14a6000 b150a000 r-xp /usr/lib/libasound.so.2.0.0
b1514000 b1517000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1520000 b1524000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b152d000 b154a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b1552000 b1556000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b155e000 b158b000 r-xp /usr/lib/libSLP-location.so.0.0.0
b1594000 b15d1000 r-xp /usr/lib/libmdm.so.1.0.63
b15d9000 b15dd000 r-xp /usr/lib/libss-client.so.1.0.0
b15e6000 b15ef000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b15f7000 b15fb000 r-xp /usr/lib/libmmffile.so.0.0.0
b1603000 b160a000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1612000 b162c000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b1634000 b164f000 r-xp /usr/lib/libmedia-service.so.1.0.0
b1657000 b166c000 r-xp /usr/lib/libnetwork.so.0.0.0
b1674000 b1682000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.6
b168b000 b1692000 r-xp /usr/lib/libenchant.so.1.6.1
b169a000 b169d000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b16a6000 b16af000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b16b8000 b16bc000 r-xp /usr/lib/libmmfsession.so.0.0.0
b16c5000 b16d3000 r-xp /usr/lib/libmmfsound.so.0.1.0
b16db000 b16e0000 r-xp /usr/lib/libmemenv.so.1.1.0
b16e8000 b1726000 r-xp /usr/lib/libleveldb.so.1.1.0
b172f000 b1759000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b1762000 b1764000 r-xp /usr/lib/libsecfw.so
b176c000 b1775000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1780000 b178f000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1797000 b17af000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b17b1000 b17be000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b17c7000 b17d0000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b17d8000 b181a000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1823000 b18bf000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b18cb000 b18f0000 r-xp /usr/lib/libxslt.so.1.1.16
b18f9000 b18fb000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b1903000 b190b000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1913000 b191e000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b1926000 b1941000 r-xp /usr/lib/libwifi-direct.so.0.0
b1949000 b1951000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.6
b1959000 b1962000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b196a000 b196d000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b1975000 b199c000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b19a4000 b19ba000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b19c3000 b19cd000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b19d5000 b19de000 r-xp /usr/lib/libcapi-web-favorites.so
b19e6000 b2c36000 r-xp /usr/lib/libewebkit2.so.0.10.141.3
b2d28000 b2ddd000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2dea000 b2e08000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e11000 b2e2b000 r-xp /usr/lib/osp/libosp-json.so.1.2.1.0
b2e34000 b2e87000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2e90000 b2ef4000 r-xp /usr/lib/osp/libosp-web.so.1.2.1.0
b2f07000 b2f11000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2f19000 b2f34000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana.exe
b2f3d000 b2f85000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f8d000 b301d000 r-xp /usr/lib/libCOREGL.so.3.0
b3027000 b302a000 r-xp /usr/lib/libmm_ta.so.0.0.0
b3032000 b3039000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3042000 b3051000 r-xp /usr/lib/libICE.so.6.3.0
b305b000 b3060000 r-xp /usr/lib/libSM.so.6.0.1
b3068000 b3069000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3071000 b3073000 r-xp /usr/lib/libledplayer.so.0.1
b307b000 b3081000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3089000 b308a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3093000 b309a000 r-xp /usr/lib/libGLESv2.so.2.0
b30a2000 b30e9000 r-xp /usr/lib/libtiff.so.5.1.0
b30f4000 b311d000 r-xp /usr/lib/libturbojpeg.so
b3136000 b313a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3143000 b3149000 r-xp /usr/lib/libgif.so.4.1.6
b3151000 b3173000 r-xp /usr/lib/libavutil.so.51.73.101
b3182000 b31b0000 r-xp /usr/lib/libswscale.so.2.1.101
b31b9000 b34b0000 r-xp /usr/lib/libavcodec.so.54.59.100
b37d7000 b37f0000 r-xp /usr/lib/libpng12.so.0.50.0
b37f9000 b3800000 r-xp /usr/lib/libfeedback.so.0.1.4
b3809000 b381c000 r-xp /usr/lib/libtts.so
b3824000 b3826000 r-xp /usr/lib/libEGL.so.1.4
b382e000 b38e5000 r-xp /usr/lib/libcairo.so.2.11200.12
b38ef000 b3908000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3912000 b3917000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b391f000 b3921000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana
b3929000 b41cb000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b423b000 b4244000 r-xp /usr/lib/libslp_devman_plugin.so
b424d000 b424f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b4257000 b425a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4262000 b4265000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b426d000 b427a000 r-xp /usr/lib/libmodem.so.0.0.0
b4282000 b4285000 r-xp /usr/lib/libdevice-node.so.0.1
b428d000 b429d000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b42a5000 b42a8000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b42b0000 b42bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b42c3000 b42ca000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b42d3000 b42d8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b42e0000 b42e1000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b42ea000 b42ed000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b42f5000 b42fa000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4302000 b4305000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b430d000 b430e000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b4316000 b4324000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b432d000 b4333000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b433b000 b4360000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b4368000 b436b000 r-xp /usr/lib/libuuid.so.1.3.0
b4374000 b4388000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4390000 b4391000 r-xp /usr/lib/libpmapi.so.1.2
b4399000 b43a1000 r-xp /usr/lib/libminizip.so.1.0.0
b43a9000 b43b5000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b43be000 b43dc000 r-xp /usr/lib/libpcre.so.0.0.1
b43e4000 b43e8000 r-xp /usr/lib/libheynoti.so.0.0.2
b43f0000 b43fe000 r-xp /usr/lib/libdeviced.so.0.1.0
b4407000 b4412000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b441f000 b4428000 r-xp /usr/lib/libdevman.so.0.1
b4430000 b4434000 r-xp /usr/lib/libchromium.so.1.0
b443c000 b4443000 r-xp /usr/lib/libalarm.so.0.0.0
b444b000 b4758000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b4780000 b478a000 r-xp /lib/libnss_files-2.13.so
b479a000 b47aa000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.3
b47ab000 b47be000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b47c6000 b47e3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b47eb000 b47ee000 r-xp /usr/lib/libiniparser.so.0
b47f7000 b4847000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b4851000 b4865000 r-xp /usr/lib/libcom-core.so.0.0.1
b486d000 b4873000 r-xp /usr/lib/libappsvc.so.0.1.0
b487b000 b487d000 r-xp /usr/lib/libdri2.so.0.0.0
b4885000 b488d000 r-xp /usr/lib/libdrm.so.2.4.0
b4895000 b4899000 r-xp /usr/lib/libtbm.so.1.0.0
b48a1000 b48a4000 r-xp /usr/lib/libXv.so.1.0.0
b48ac000 b4978000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b498e000 b499d000 r-xp /usr/lib/libnotification.so.0.1.0
b49a5000 b49c9000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b49d2000 b49e2000 r-xp /lib/libresolv-2.13.so
b49e6000 b49e8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49f0000 b4ac8000 r-xp /usr/lib/libxml2.so.2.7.8
b4ad5000 b4bb2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4bbd000 b4bc2000 r-xp /usr/lib/libcheck.so.0.0.0
b4bca000 b4bd4000 r-xp /usr/lib/libspdy.so.0.0.0
b4bdd000 b4d30000 r-xp /usr/lib/libcrypto.so.1.0.0
b4d4e000 b4d9a000 r-xp /usr/lib/libssl.so.1.0.0
b4da6000 b4dd4000 r-xp /usr/lib/libidn.so.11.5.44
b4ddd000 b4de7000 r-xp /usr/lib/libcares.so.2.1.0
b4def000 b4e06000 r-xp /lib/libexpat.so.1.5.2
b4e10000 b4e34000 r-xp /usr/lib/libicule.so.48.1
b4e3d000 b4e4b000 r-xp /usr/lib/libsf_common.so
b4e54000 b4eef000 r-xp /usr/lib/libstdc++.so.6.0.14
b4f02000 b4f1a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4f1b000 b4f1e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4f26000 b4f2a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4f33000 b4f38000 r-xp /usr/lib/libffi.so.5.0.10
b4f40000 b4f41000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4f49000 b4f53000 r-xp /usr/lib/libXext.so.6.4.0
b4f5c000 b4f5f000 r-xp /usr/lib/libXtst.so.6.1.0
b4f67000 b4f6d000 r-xp /usr/lib/libXrender.so.1.3.0
b4f75000 b4f7b000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f83000 b4f84000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f8d000 b4f96000 r-xp /usr/lib/libXi.so.6.1.0
b4f9e000 b4fa1000 r-xp /usr/lib/libXfixes.so.3.1.0
b4fa9000 b4fab000 r-xp /usr/lib/libXgesture.so.7.0.0
b4fb3000 b4fb4000 r-xp /usr/lib/libXdamage.so.1.1.0
b4fbd000 b4fc4000 r-xp /usr/lib/libXcursor.so.1.0.2
b4fcc000 b4fef000 r-xp /usr/lib/libexif.so.12.3.3
b5003000 b500d000 r-xp /usr/lib/libethumb.so.1.7.99
b5015000 b5059000 r-xp /usr/lib/libsndfile.so.1.0.25
b5067000 b5069000 r-xp /usr/lib/libctxdata.so.0.0.0
b5071000 b507f000 r-xp /usr/lib/libremix.so.0.0.0
b5087000 b5088000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5090000 b50a9000 r-xp /usr/lib/liblua-5.1.so
b50b2000 b50b9000 r-xp /usr/lib/libembryo.so.1.7.99
b50c2000 b5102000 r-xp /usr/lib/libcurl.so.4.3.0
b510b000 b5175000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5182000 b51a6000 r-xp /usr/lib/libfontconfig.so.1.5.0
b51af000 b520b000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b521d000 b5231000 r-xp /usr/lib/libfribidi.so.0.3.1
b5239000 b5291000 r-xp /usr/lib/libfreetype.so.6.8.1
b529c000 b52c0000 r-xp /usr/lib/libjpeg.so.8.0.2
b52d8000 b52ef000 r-xp /lib/libz.so.1.2.5
b52f7000 b52ff000 r-xp /usr/lib/libemotion.so.1.7.99
b5307000 b530c000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5315000 b5323000 r-xp /usr/lib/libsensor.so.1.1.0
b532f000 b5335000 r-xp /usr/lib/libappcore-common.so.1.1
b533d000 b533f000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.78
b5347000 b5350000 r-xp /usr/lib/libresourced.so.0.2.78
b5359000 b535c000 r-xp /usr/lib/libproc-stat.so.0.2.78
b6359000 b6441000 r-xp /usr/lib/libicuuc.so.48.1
b644e000 b656e000 r-xp /usr/lib/libicui18n.so.48.1
b657c000 b657f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6587000 b6590000 r-xp /usr/lib/libvconf.so.0.2.45
b6598000 b659e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a6000 b65b2000 r-xp /usr/lib/libail.so.0.1.0
b65ba000 b65c5000 r-xp /usr/lib/libaul.so.0.1.0
b65cd000 b65e4000 r-xp /usr/lib/libecore_input.so.1.7.99
b65ff000 b661c000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6625000 b6627000 r-xp /usr/lib/libXcomposite.so.1.0.0
b662f000 b6663000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b666c000 b669b000 r-xp /usr/lib/libecore_x.so.1.7.99
b66a5000 b66e4000 r-xp /usr/lib/libeina.so.1.7.99
b66ed000 b6702000 r-xp /usr/lib/libecore.so.1.7.99
b6719000 b6734000 r-xp /usr/lib/libecore_con.so.1.7.99
b673d000 b6742000 r-xp /usr/lib/libecore_imf.so.1.7.99
b674a000 b6752000 r-xp /usr/lib/libethumb_client.so.1.7.99
b675a000 b6763000 r-xp /usr/lib/libedbus.so.1.7.99
b676b000 b676d000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6775000 b6779000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6782000 b6798000 r-xp /usr/lib/libefreet.so.1.7.99
b67a2000 b67fe000 r-xp /usr/lib/libedje.so.1.7.99
b6808000 b68b8000 r-xp /usr/lib/libevas.so.1.7.99
b68da000 b68ed000 r-xp /usr/lib/libeet.so.1.7.99
b68f6000 b6960000 r-xp /lib/libm-2.13.so
b6969000 b6971000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b6972000 b6979000 r-xp /usr/lib/libutilX.so.1.1.0
b6981000 b6aa3000 r-xp /usr/lib/libelementary.so.1.7.99
b6ab8000 b6abb000 r-xp /lib/libattr.so.1.1.0
b6ac3000 b6ac5000 r-xp /usr/lib/libXau.so.6.0.0
b6acd000 b6ad3000 r-xp /lib/librt-2.13.so
b6adc000 b6ae4000 r-xp /lib/libcrypt-2.13.so
b6b14000 b6b17000 r-xp /lib/libcap.so.2.21
b6b1f000 b6b21000 r-xp /usr/lib/libiri.so
b6b29000 b6b3e000 r-xp /usr/lib/libxcb.so.1.1.0
b6b46000 b6b51000 r-xp /lib/libunwind.so.8.0.1
b6b7f000 b6c9c000 r-xp /lib/libc-2.13.so
b6caa000 b6cb3000 r-xp /lib/libgcc_s-4.5.3.so.1
b6cbb000 b6ce7000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6cf0000 b6cf3000 r-xp /usr/lib/libbundle.so.0.1.22
b6cfb000 b6cfd000 r-xp /lib/libdl-2.13.so
b6d06000 b6d09000 r-xp /usr/lib/libsmack.so.1.0.0
b6d11000 b6deb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6df4000 b6e08000 r-xp /lib/libpthread-2.13.so
b6e14000 b6e19000 r-xp /usr/lib/libecore_file.so.1.7.99
b6e21000 b6e29000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e2b000 b6e2c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e35000 b6ea2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6eac000 b6eb5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ebd000 b6fa3000 r-xp /usr/lib/libX11.so.6.3.0
b6fae000 b6faf000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6fb7000 b6fbb000 r-xp /usr/lib/libsys-assert.so
b6fc3000 b6fe0000 r-xp /lib/ld-2.13.so
be86d000 be88e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10280)
Call Stack Count: 35
 0: (0xb3e0f1f0) [/usr/lib/osp/libosp-uifw.so] + 0x4e61f0
 1: Tizen::Ui::Controls::ListView::Construct(Tizen::Graphics::Rectangle const&, bool, Tizen::Ui::Controls::ListScrollStyle) + 0x12 (0xb3e04543) [/usr/lib/osp/libosp-uifw.so] + 0x4db543
 2: MyHondanaMainForm::SortMenu() + 0xf0 (0xb2f29b24) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0x10b24
 3: MyHondanaMainForm::OnInitializing() + 0x80 (0xb2f29444) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0x10444
 4: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3bd3563) [/usr/lib/osp/libosp-uifw.so] + 0x2aa563
 5: Tizen::Ui::Controls::_FormImpl::OnAttachedToMainTree() + 0x28 (0xb3d8b6c9) [/usr/lib/osp/libosp-uifw.so] + 0x4626c9
 6: Tizen::Ui::_Control::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0xb2 (0xb3bbbdbf) [/usr/lib/osp/libosp-uifw.so] + 0x292dbf
 7: Tizen::Ui::_Control::EndAttaching(Tizen::Ui::_Control&) + 0xec (0xb3bbef19) [/usr/lib/osp/libosp-uifw.so] + 0x295f19
 8: Tizen::Ui::_Control::AttachChild(Tizen::Ui::_Control&) + 0x5a (0xb3bc190b) [/usr/lib/osp/libosp-uifw.so] + 0x29890b
 9: Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool) + 0xa4 (0xb3bdea6d) [/usr/lib/osp/libosp-uifw.so] + 0x2b5a6d
10: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x26 (0xb3bb617b) [/usr/lib/osp/libosp-uifw.so] + 0x28d17b
11: Tizen::Ui::Container::AddControl(Tizen::Ui::Control const&) + 0x6 (0xb3bb6207) [/usr/lib/osp/libosp-uifw.so] + 0x28d207
12: (0xb3e53b57) [/usr/lib/osp/libosp-uifw.so] + 0x52ab57
13: (0xb3e5449f) [/usr/lib/osp/libosp-uifw.so] + 0x52b49f
14: (0xb3e5701d) [/usr/lib/osp/libosp-uifw.so] + 0x52e01d
15: Tizen::Ui::Scenes::SceneManager::GoForward(Tizen::Ui::Scenes::ForwardSceneTransition const&, Tizen::Base::Collection::IList const*) + 0x18 (0xb3e4bb25) [/usr/lib/osp/libosp-uifw.so] + 0x522b25
16: MyHondanaFrame::OnInitializing() + 0x64 (0xb2f2855c) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xf55c
17: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3bd3563) [/usr/lib/osp/libosp-uifw.so] + 0x2aa563
18: Tizen::Ui::Controls::_FrameImpl::OnAttachedToMainTree() + 0xa (0xb3d8e5e7) [/usr/lib/osp/libosp-uifw.so] + 0x4655e7
19: Tizen::Ui::_ControlManager::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0x76 (0xb3be28c7) [/usr/lib/osp/libosp-uifw.so] + 0x2b98c7
20: Tizen::Ui::_ControlManager::ActivateWindow(Tizen::Ui::_Window&, bool) + 0xcc (0xb3be32f5) [/usr/lib/osp/libosp-uifw.so] + 0x2ba2f5
21: Tizen::Ui::_ControlManager::OpenWindow(Tizen::Ui::_Window&, bool) + 0x2e (0xb3be3507) [/usr/lib/osp/libosp-uifw.so] + 0x2ba507
22: Tizen::Ui::_Window::Open(bool) + 0x3c (0xb3bd0821) [/usr/lib/osp/libosp-uifw.so] + 0x2a7821
23: Tizen::Ui::_WindowImpl::Open(bool) + 0x12 (0xb3be0897) [/usr/lib/osp/libosp-uifw.so] + 0x2b7897
24: Tizen::App::_UiAppImpl::AddFrame(Tizen::Ui::Controls::Frame const&) + 0x40 (0xb3f88f35) [/usr/lib/osp/libosp-uifw.so] + 0x65ff35
25: Tizen::App::UiApp::AddFrame(Tizen::Ui::Controls::Frame const&) + 0x14 (0xb3f882f9) [/usr/lib/osp/libosp-uifw.so] + 0x65f2f9
26: MyHondanaApp::OnAppInitialized() + 0x88 (0xb2f25258) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xc258
27: Tizen::App::_UiAppImpl::OnAppInitialized() + 0x18 (0xb3f887dd) [/usr/lib/osp/libosp-uifw.so] + 0x65f7dd
28: Tizen::App::_AppImpl::OnService(service_s*, void*) + 0x1da (0xb453b39f) [/usr/lib/osp/libosp-appfw.so] + 0xf039f
29: (0xb431fbdd) [/usr/lib/libcapi-appfw-application.so.0] + 0x9bdd
30: (0xb6e23f28) [/usr/lib/libappcore-efl.so.1] + 0x2f28
31: (0xb533094c) [/usr/lib/libappcore-common.so.1] + 0x194c
32: (0xb5331024) [/usr/lib/libappcore-common.so.1] + 0x2024
33: (0xb65bd1a9) [/usr/lib/libaul.so.0] + 0x31a9
dladdr failed 34: (0x817c0) (null)
End of Call Stack

Package Information
Package Name: vMEuS5j7iC.MyHondana
Package ID : vMEuS5j7iC
Version: 1.0.0
Package Type: tpk
App Name: MyHondana
App ID: vMEuS5j7iC.MyHondana
Type: Application
Categories: (NULL)
