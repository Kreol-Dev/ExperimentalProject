namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Place AddContext10 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext10 ContextSwitchInterpreter
								if(AddContext10 != null)
								{
									System.Single OperandVar12 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop11 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar12 = prop11;
									AddContext10.Size = (System.Int32)( (OperandVar12));
								}
							}
							Named AddContext13 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext13 ContextSwitchInterpreter
								if(AddContext13 != null)
								{
									
									
									
									AddContext13.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar16 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar14 = default(System.String); //IsContext = False IsNew = False
									OperandVar14 = "human_name";
									System.String prop15 = External.RandomName( (OperandVar14)); //IsContext = False IsNew = False
									if(prop15 != null)
									{
										OperandVar16 = prop15;
									}
									AddContext13.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar16)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar18 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable17 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable17 != null)
						{
							OperandVar18 = StoredVariable17;
						}
						subContext5.Attach((Place)( (OperandVar18)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable19 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable19 != null)
			{
				System.Boolean ifResult20; //IsContext = False IsNew = False
				
				System.Boolean OperandVar27 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop21 = StoredVariable19.ShowedObject; //IsContext = False IsNew = False
				if(prop21 != null)
				{
					System.Boolean ifResult22; //IsContext = False IsNew = False
					System.Boolean OperandVar26 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar24 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable23 = ((Named)prop21.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable23 != null)
					{
						OperandVar24 = StoredVariable23;
					}
					System.Boolean prop25 = External.Has( (OperandVar24)); //IsContext = False IsNew = False
					OperandVar26 = prop25;
					if(ifResult22 =  (OperandVar26))
					{
						OperandVar27 = ifResult22;
					}
				}
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar29 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable28 = ((Blackboards.named_ui_marker)StoredVariable19.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable28 != null)
				{
					OperandVar29 = StoredVariable28;
				}
				System.Boolean prop30 = External.Has( (OperandVar29)); //IsContext = False IsNew = False
				OperandVar31 = prop30;
				if(ifResult20 = ( ( (OperandVar27))) && ( (!(OperandVar31))))
				{
					applicable = true;
					OperandVar32 = applicable;
				}
			}
			return (System.Boolean) (OperandVar32);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.named_ui_marker>();
			Entity EntVar33 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			
			
			{
				UiObject subContext34 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext34 ContextSwitchInterpreter
				if(subContext34 != null)
				{
					Named OperandVar37 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop35 = subContext34.ShowedObject; //IsContext = False IsNew = False
					if(prop35 != null)
					{
						Named StoredVariable36 = ((Named)prop35.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable36 != null)
						{
							OperandVar37 = StoredVariable36;
						}
					}
					Named showed_named =  (OperandVar37); //IsContext = False IsNew = False
					TextField ContextVar38 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar38 ContextSwitchInterpreter
						if(ContextVar38 != null)
						{
							System.String OperandVar40 = default(System.String); //IsContext = False IsNew = False
							System.String prop39 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop39 != null)
							{
								OperandVar40 = prop39;
							}
							ContextVar38.Show(( (OperandVar40)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda41 = () => 
									{
										System.String OperandVar43 = default(System.String); //IsContext = False IsNew = False
										System.String prop42 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop42 != null)
										{
											OperandVar43 = prop42;
										}
										ContextVar38.Show(( (OperandVar43)).ToString());
									};
									showed_named.OnUpdate(Lambda41);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext44 = ContextVar38.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext44 ContextPropertySwitchInterpreter
								if(subContext44 != null)
								{
									
									subContext44.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					if(EntVar33 != null) EntVar33.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar58 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable45 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable45 != null)
			{
				UiObject StoredVariable46 = ((UiObject)StoredVariable45.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable46 != null)
				{
					System.Boolean ifResult47; //IsContext = False IsNew = False
					
					System.Boolean OperandVar54 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop48 = StoredVariable46.ShowedObject; //IsContext = False IsNew = False
					if(prop48 != null)
					{
						System.Boolean ifResult49; //IsContext = False IsNew = False
						System.Boolean OperandVar53 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar51 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable50 = ((Place)prop48.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable50 != null)
						{
							OperandVar51 = StoredVariable50;
						}
						System.Boolean prop52 = External.Has( (OperandVar51)); //IsContext = False IsNew = False
						OperandVar53 = prop52;
						if(ifResult49 =  (OperandVar53))
						{
							OperandVar54 = ifResult49;
						}
					}
					
					System.Boolean OperandVar57 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar55 = default(System.String); //IsContext = False IsNew = False
					OperandVar55 = "place_ui_set";
					System.Boolean prop56 = StoredVariable45.HasMarker( (OperandVar55)); //IsContext = False IsNew = False
					OperandVar57 = prop56;
					if(ifResult47 = ( ( (OperandVar54))) && ( (!(OperandVar57))))
					{
						applicable = true;
						OperandVar58 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar58);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext59 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext59 ContextSwitchInterpreter
				if(subContext59 != null)
				{
					System.String OperandVar60 = default(System.String); //IsContext = False IsNew = False
					OperandVar60 = "place_ui_set";
					subContext59.SetMarker(( (OperandVar60)).ToString());
				}
			}
			
			{
				UiObject subContext61 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext61 ContextSwitchInterpreter
				if(subContext61 != null)
				{
					Place OperandVar64 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop62 = subContext61.ShowedObject; //IsContext = False IsNew = False
					if(prop62 != null)
					{
						Place StoredVariable63 = ((Place)prop62.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable63 != null)
						{
							OperandVar64 = StoredVariable63;
						}
					}
					Place pl =  (OperandVar64); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					Entity EntVar65 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar67 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop66 = pl.Size; //IsContext = False IsNew = False
							OperandVar67 = prop66;
							puidata.LastSize = (System.Int32)( (OperandVar67));
						}
					}
					TextField ContextVar68 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar68 ContextSwitchInterpreter
						if(ContextVar68 != null)
						{
							System.Int32 OperandVar70 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop69 = pl.Size; //IsContext = False IsNew = False
							OperandVar70 = prop69;
							ContextVar68.Show(( (OperandVar70)).ToString());
							System.Boolean OperandVar74 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar72 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable71 = ((Updated)ContextVar68.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable71 != null)
							{
								OperandVar72 = StoredVariable71;
							}
							System.Boolean prop73 = External.Has( (OperandVar72)); //IsContext = False IsNew = False
							OperandVar74 = prop73;
							if(!(OperandVar74))
							{
								root.AddComponent<Updated>();
								
							}
							
							{
								//ContextStatement TextField ContextVar68 ContextSwitchInterpreter
								if(ContextVar68 != null)
								{
									
									ContextVar68.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext75 = ContextVar68.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext75 ContextPropertySwitchInterpreter
								if(subContext75 != null)
								{
									
									subContext75.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext76 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext76 ContextSwitchInterpreter
								if(subContext76 != null)
								{
									BoolDelegate Lambda77 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar79 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop78 = pl.Size; //IsContext = False IsNew = False
															OperandVar79 = prop78;
														}
														
														System.Int32 OperandVar81 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop80 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar81 = prop80;
														}
														if(!(( ( (OperandVar79))) == ( ( (OperandVar81)))))
														{
															System.Int32 OperandVar83 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop82 = pl.Size; //IsContext = False IsNew = False
																OperandVar83 = prop82;
															}
															puidata.LastSize = (System.Int32)( (OperandVar83));
															System.Int32 OperandVar85 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop84 = pl.Size; //IsContext = False IsNew = False
																OperandVar85 = prop84;
															}
															ContextVar68.Show(( (OperandVar85)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext76.OnUpdate(Lambda77);
								}
							}
						}
					}
					if(EntVar65 != null) EntVar65.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar94 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable86 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable86 != null)
			{
				Place StoredVariable87 = ((Place)StoredVariable86.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable87 != null)
				{
					System.Boolean ifResult88; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar90 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop89 = StoredVariable87.Agents; //IsContext = False IsNew = False
					if(prop89 != null)
					{
						OperandVar90 = prop89;
					}
					
					
					
					System.Boolean OperandVar93 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar91 = default(System.String); //IsContext = False IsNew = False
					OperandVar91 = "agents_pool";
					System.Boolean prop92 = StoredVariable86.HasMarker( (OperandVar91)); //IsContext = False IsNew = False
					OperandVar93 = prop92;
					if(ifResult88 = ( (( ( (OperandVar90 != null ? OperandVar90.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar93))))
					{
						applicable = true;
						OperandVar94 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar94);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext95 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext95 ContextSwitchInterpreter
				if(subContext95 != null)
				{
					
					subContext95.Size = (System.Int32)( (5f));
					System.Single OperandVar97 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop96 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar97 = prop96;
					for (int i = 0; i <  (OperandVar97); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag98 = ag; //IsContext = True IsNew = False
							Entity AddContext99 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext100 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext101 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext101 ContextSwitchInterpreter
								if(AddContext101 != null)
								{
									System.Single OperandVar103 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop102 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar103 = prop102;
									AddContext101.Age = (System.Int32)( (OperandVar103));
								}
							}
							Named AddContext104 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext104 ContextSwitchInterpreter
								if(AddContext104 != null)
								{
									
									
									
									AddContext104.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar107 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar105 = default(System.String); //IsContext = False IsNew = False
									OperandVar105 = "human_name";
									System.String prop106 = External.RandomName( (OperandVar105)); //IsContext = False IsNew = False
									if(prop106 != null)
									{
										OperandVar107 = prop106;
									}
									AddContext104.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar107)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar109 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable108 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable108 != null)
						{
							OperandVar109 = StoredVariable108;
						}
						subContext95.Attach((Agent)( (OperandVar109)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar116 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable110 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable110 != null)
			{
				System.Boolean ifResult111; //IsContext = False IsNew = False
				System.Boolean OperandVar115 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar113 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable112 = ((Blackboards.event_marker)StoredVariable110.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable112 != null)
				{
					OperandVar113 = StoredVariable112;
				}
				System.Boolean prop114 = External.Has( (OperandVar113)); //IsContext = False IsNew = False
				OperandVar115 = prop114;
				if(ifResult111 = !(OperandVar115))
				{
					applicable = true;
					OperandVar116 = applicable;
				}
			}
			return (System.Boolean) (OperandVar116);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar117 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar117 != null) EntVar117.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar124 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable118 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable118 != null)
			{
				System.Boolean ifResult119; //IsContext = False IsNew = False
				System.Boolean OperandVar123 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar121 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable120 = ((Blackboards.personality)StoredVariable118.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable120 != null)
				{
					OperandVar121 = StoredVariable120;
				}
				System.Boolean prop122 = External.Has( (OperandVar121)); //IsContext = False IsNew = False
				OperandVar123 = prop122;
				if(ifResult119 = !(OperandVar123))
				{
					applicable = true;
					OperandVar124 = applicable;
				}
			}
			return (System.Boolean) (OperandVar124);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar125 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar125 != null) EntVar125.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar132 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable126 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable126 != null)
			{
				System.Boolean ifResult127; //IsContext = False IsNew = False
				System.Boolean OperandVar131 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar129 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable128 = ((Blackboards.aged_generation)StoredVariable126.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable128 != null)
				{
					OperandVar129 = StoredVariable128;
				}
				System.Boolean prop130 = External.Has( (OperandVar129)); //IsContext = False IsNew = False
				OperandVar131 = prop130;
				if(ifResult127 = !(OperandVar131))
				{
					applicable = true;
					OperandVar132 = applicable;
				}
			}
			return (System.Boolean) (OperandVar132);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar133 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar133 != null) EntVar133.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar143 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable134 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable134 != null)
			{
				Lore StoredVariable135 = ((Lore)StoredVariable134.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable135 != null)
				{
					Place StoredVariable136 = ((Place)StoredVariable135.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable136 != null)
					{
						System.Boolean ifResult137; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar139 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop138 = StoredVariable136.Agents; //IsContext = False IsNew = False
						if(prop138 != null)
						{
							OperandVar139 = prop138;
						}
						
						
						
						System.Boolean OperandVar142 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar140 = default(System.String); //IsContext = False IsNew = False
						OperandVar140 = "lore_pool";
						System.Boolean prop141 = StoredVariable134.HasMarker( (OperandVar140)); //IsContext = False IsNew = False
						OperandVar142 = prop141;
						if(ifResult137 = ( (( ( (OperandVar139 != null ? OperandVar139.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar142))))
						{
							applicable = true;
							OperandVar143 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar143);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext144 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext144 ContextSwitchInterpreter
				if(subContext144 != null)
				{
					
					subContext144.Size = (System.Int32)( (10f));
					System.Single OperandVar146 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop145 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar146 = prop145;
					for (int i = 0; i <  (OperandVar146); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag147 = old_ag; //IsContext = True IsNew = False
							Entity AddContext148 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext149 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext150 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext151 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext151 ContextSwitchInterpreter
								if(AddContext151 != null)
								{
									System.Single OperandVar153 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop152 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar153 = prop152;
									AddContext151.Age = (System.Int32)( (OperandVar153));
								}
							}
							Named AddContext154 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext154 ContextSwitchInterpreter
								if(AddContext154 != null)
								{
									
									
									
									AddContext154.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar157 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar155 = default(System.String); //IsContext = False IsNew = False
									OperandVar155 = "human_name";
									System.String prop156 = External.RandomName( (OperandVar155)); //IsContext = False IsNew = False
									if(prop156 != null)
									{
										OperandVar157 = prop156;
									}
									AddContext154.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar157)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar159 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable158 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable158 != null)
						{
							OperandVar159 = StoredVariable158;
						}
						subContext144.Attach((Agent)( (OperandVar159)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar169 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable160 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable160 != null)
			{
				Blackboards.historical_person StoredVariable161 = ((Blackboards.historical_person)StoredVariable160.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable161 != null)
				{
					Named StoredVariable162 = ((Named)StoredVariable161.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable162 != null)
					{
						Agent StoredVariable163 = ((Agent)StoredVariable162.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable163 != null)
						{
							System.Boolean ifResult164; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar166 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop165 = StoredVariable163.Act; //IsContext = False IsNew = False
							OperandVar166 = prop165;
							
							
							
							System.Boolean OperandVar168 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable160 != null)
							{
								System.Boolean prop167 = StoredVariable160.Dead; //IsContext = False IsNew = False
								OperandVar168 = prop167;
							}
							if(ifResult164 = ( (( ( (OperandVar166))) == ( ( (true))))) && ( (!(OperandVar168))))
							{
								applicable = true;
								OperandVar169 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar169);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext170 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext170 ContextSwitchInterpreter
				if(subContext170 != null)
				{
					
					System.String OperandVar173 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar171 = default(System.String); //IsContext = False IsNew = False
					OperandVar171 = "human_name";
					System.String prop172 = External.RandomName( (OperandVar171)); //IsContext = False IsNew = False
					if(prop172 != null)
					{
						OperandVar173 = prop172;
					}
					subContext170.Switch(( ("main_name")).ToString(),( (OperandVar173)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar179 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable174 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable174 != null)
			{
				Named StoredVariable175 = ((Named)StoredVariable174.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable175 != null)
				{
					System.Boolean ifResult176; //IsContext = False IsNew = False
					
					System.Boolean OperandVar178 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable174 != null)
					{
						System.Boolean prop177 = StoredVariable174.Act; //IsContext = False IsNew = False
						OperandVar178 = prop177;
					}
					
					
					if(ifResult176 = ( ( (OperandVar178))) == ( ( (true))))
					{
						applicable = true;
						OperandVar179 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar179);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar183 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable180 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable180 != null)
			{
				System.String OperandVar181 = default(System.String); //IsContext = False IsNew = False
				OperandVar181 = "main_name";
				System.String prop182 = StoredVariable180.Get( (OperandVar181)); //IsContext = False IsNew = False
				if(prop182 != null)
				{
					OperandVar183 = prop182;
				}
			}
			External.Log((System.Object)( (OperandVar183)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar191 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable184 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable184 != null)
			{
				Agent StoredVariable185 = ((Agent)StoredVariable184.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable185 != null)
				{
					System.Boolean ifResult186; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar188 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop187 = StoredVariable185.Act; //IsContext = False IsNew = False
					OperandVar188 = prop187;
					
					
					
					System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable184 != null)
					{
						System.Boolean prop189 = StoredVariable184.Dead; //IsContext = False IsNew = False
						OperandVar190 = prop189;
					}
					if(ifResult186 = ( (( ( (OperandVar188))) == ( ( (true))))) && ( (!(OperandVar190))))
					{
						applicable = true;
						OperandVar191 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar191);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar192 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar192 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar192)))));
			UnityEngine.GameObject OperandVar193 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar193 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar193)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar202 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable194 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable194 != null)
			{
				System.Boolean ifResult195; //IsContext = False IsNew = False
				
				System.Boolean OperandVar198 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar196 = default(System.String); //IsContext = False IsNew = False
				OperandVar196 = "init_node";
				System.Boolean prop197 = StoredVariable194.HasMarker( (OperandVar196)); //IsContext = False IsNew = False
				OperandVar198 = prop197;
				
				System.Boolean OperandVar201 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar199 = default(System.String); //IsContext = False IsNew = False
				OperandVar199 = "story_set";
				System.Boolean prop200 = StoredVariable194.HasMarker( (OperandVar199)); //IsContext = False IsNew = False
				OperandVar201 = prop200;
				if(ifResult195 = ( ( (OperandVar198))) && ( (!(OperandVar201))))
				{
					applicable = true;
					OperandVar202 = applicable;
				}
			}
			return (System.Boolean) (OperandVar202);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext203 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext203 ContextSwitchInterpreter
				if(subContext203 != null)
				{
					System.String OperandVar204 = default(System.String); //IsContext = False IsNew = False
					OperandVar204 = "story_set";
					subContext203.SetMarker(( (OperandVar204)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node205 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext206 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext207 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Markers AddContext208 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext209 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext209 ContextPropertySwitchInterpreter
				if(subContext209 != null)
				{
					
					{
						TaleNode subContext210 = (TaleNode)subContext209.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext210 ContextSwitchInterpreter
						if(subContext210 != null)
						{
							
							subContext210.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar220 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable211 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable211 != null)
			{
				Blackboards.story_node StoredVariable212 = ((Blackboards.story_node)StoredVariable211.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable212 != null)
				{
					TaleNode StoredVariable213 = ((TaleNode)StoredVariable212.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable213 != null)
					{
						System.Boolean ifResult214; //IsContext = False IsNew = False
						
						System.Boolean OperandVar217 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar215 = default(System.String); //IsContext = False IsNew = False
						OperandVar215 = "decomposed";
						System.Boolean prop216 = StoredVariable211.HasMarker( (OperandVar215)); //IsContext = False IsNew = False
						OperandVar217 = prop216;
						
						System.Boolean OperandVar219 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop218 = StoredVariable213.IsActive; //IsContext = False IsNew = False
						OperandVar219 = prop218;
						if(ifResult214 = ( (!(OperandVar217))) && ( ( (OperandVar219))))
						{
							applicable = true;
							OperandVar220 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar220);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext221 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext221 ContextSwitchInterpreter
				if(subContext221 != null)
				{
					System.String OperandVar222 = default(System.String); //IsContext = False IsNew = False
					OperandVar222 = "decomposed";
					subContext221.SetMarker(( (OperandVar222)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node223 = c_node; //IsContext = True IsNew = False
				Markers AddContext224 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext225 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext226 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node227 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext228 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext229 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext230 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext230 ContextSwitchInterpreter
					if(AddContext230 != null)
					{
						UnityEngine.GameObject OperandVar231 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar231 = c_node;
						AddContext230.Conflict = (UnityEngine.GameObject)( (OperandVar231));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node232 = r_node; //IsContext = True IsNew = False
				Markers AddContext233 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext234 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext235 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext235 ContextSwitchInterpreter
					if(AddContext235 != null)
					{
						UnityEngine.GameObject OperandVar236 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar236 = c_r_node;
						AddContext235.Resolution = (UnityEngine.GameObject)( (OperandVar236));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node237 = s_node; //IsContext = True IsNew = False
				Markers AddContext238 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext239 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext240 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext240 ContextSwitchInterpreter
					if(AddContext240 != null)
					{
						UnityEngine.GameObject OperandVar241 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar241 = c_r_node;
						AddContext240.Cause = (UnityEngine.GameObject)( (OperandVar241));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node242 = cris_node; //IsContext = True IsNew = False
				Markers AddContext243 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext244 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext245 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext245 ContextSwitchInterpreter
					if(AddContext245 != null)
					{
						UnityEngine.GameObject OperandVar246 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar246 = s_node;
						AddContext245.Solution = (UnityEngine.GameObject)( (OperandVar246));
						UnityEngine.GameObject OperandVar247 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar247 = r_node;
						AddContext245.Cause = (UnityEngine.GameObject)( (OperandVar247));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext248 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext248 ContextPropertySwitchInterpreter
				if(subContext248 != null)
				{
					
					{
						TaleNode subContext249 = (TaleNode)subContext248.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext249 ContextSwitchInterpreter
						if(subContext249 != null)
						{
							
							subContext249.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext250 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext250 ContextPropertySwitchInterpreter
				if(subContext250 != null)
				{
					
					{
						TaleNode subContext251 = (TaleNode)subContext250.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext251 ContextSwitchInterpreter
						if(subContext251 != null)
						{
							
							subContext251.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext252 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext252 ContextPropertySwitchInterpreter
				if(subContext252 != null)
				{
					
					{
						TaleNode subContext253 = (TaleNode)subContext252.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext253 ContextSwitchInterpreter
						if(subContext253 != null)
						{
							
							subContext253.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext254 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext254 ContextPropertySwitchInterpreter
				if(subContext254 != null)
				{
					
					{
						TaleNode subContext255 = (TaleNode)subContext254.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext255 ContextSwitchInterpreter
						if(subContext255 != null)
						{
							
							subContext255.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext256 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext256 ContextPropertySwitchInterpreter
				if(subContext256 != null)
				{
					
					{
						TaleNode subContext257 = (TaleNode)subContext256.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext257 ContextSwitchInterpreter
						if(subContext257 != null)
						{
							
							subContext257.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar267 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable258 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable258 != null)
			{
				Blackboards.conflict_node StoredVariable259 = ((Blackboards.conflict_node)StoredVariable258.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable259 != null)
				{
					TaleNode StoredVariable260 = ((TaleNode)StoredVariable259.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable260 != null)
					{
						System.Boolean ifResult261; //IsContext = False IsNew = False
						
						System.Boolean OperandVar264 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar262 = default(System.String); //IsContext = False IsNew = False
						OperandVar262 = "decomposed";
						System.Boolean prop263 = StoredVariable258.HasMarker( (OperandVar262)); //IsContext = False IsNew = False
						OperandVar264 = prop263;
						
						System.Boolean OperandVar266 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop265 = StoredVariable260.IsActive; //IsContext = False IsNew = False
						OperandVar266 = prop265;
						if(ifResult261 = ( (!(OperandVar264))) && ( ( (OperandVar266))))
						{
							applicable = true;
							OperandVar267 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar267);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node268 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext269 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext270 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext270 ContextSwitchInterpreter
						if(AddContext270 != null)
						{
							UnityEngine.GameObject OperandVar271 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar271 = root;
							AddContext270.Conflict = (UnityEngine.GameObject)( (OperandVar271));
						}
					}
					Markers AddContext272 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext273 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext273 ContextPropertySwitchInterpreter
					if(subContext273 != null)
					{
						
						{
							TaleNode subContext274 = (TaleNode)subContext273.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext274 ContextSwitchInterpreter
							if(subContext274 != null)
							{
								
								subContext274.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext275 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext275 ContextSwitchInterpreter
				if(subContext275 != null)
				{
					System.String OperandVar276 = default(System.String); //IsContext = False IsNew = False
					OperandVar276 = "decomposed";
					subContext275.SetMarker(( (OperandVar276)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar283 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable277 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable277 != null)
			{
				TaleNode StoredVariable278 = ((TaleNode)StoredVariable277.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable278 != null)
				{
					System.Boolean ifResult279; //IsContext = False IsNew = False
					System.Boolean OperandVar282 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar280 = default(System.String); //IsContext = False IsNew = False
					OperandVar280 = "tale_enlisted";
					System.Boolean prop281 = StoredVariable277.HasMarker( (OperandVar280)); //IsContext = False IsNew = False
					OperandVar282 = prop281;
					if(ifResult279 = !(OperandVar282))
					{
						applicable = true;
						OperandVar283 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar283);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui284 = ui; //IsContext = True IsNew = False
				UiObject AddContext285 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext285 ContextSwitchInterpreter
					if(AddContext285 != null)
					{
						UnityEngine.GameObject OperandVar286 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar286 = root;
						AddContext285.ShowedObject = (UnityEngine.GameObject)( (OperandVar286));
						
						{
							UnityEngine.UI.LayoutElement subContext287 = AddContext285.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext287 ContextPropertySwitchInterpreter
							if(subContext287 != null)
							{
								
								subContext287.minHeight = (System.Single)( (30f));
							}
						}
					}
				}
				TextField AddContext288 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext288 ContextSwitchInterpreter
					if(AddContext288 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext289 = AddContext288.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext289 ContextPropertySwitchInterpreter
							if(subContext289 != null)
							{
								
								subContext289.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar292 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar290 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar290 = root;
						System.String prop291 = External.Stringify( (OperandVar290)); //IsContext = False IsNew = False
						if(prop291 != null)
						{
							OperandVar292 = prop291;
						}
						AddContext288.Show(( (OperandVar292)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar293 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar293 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar293)));
			
			{
				Markers subContext294 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext294 ContextSwitchInterpreter
				if(subContext294 != null)
				{
					System.String OperandVar295 = default(System.String); //IsContext = False IsNew = False
					OperandVar295 = "tale_enlisted";
					subContext294.SetMarker(( (OperandVar295)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar302 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable296 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable296 != null)
			{
				Markers StoredVariable297 = ((Markers)StoredVariable296.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable297 != null)
				{
					System.Boolean ifResult298; //IsContext = False IsNew = False
					System.Boolean OperandVar301 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar299 = default(System.String); //IsContext = False IsNew = False
					OperandVar299 = "faction_is_a_state";
					System.Boolean prop300 = StoredVariable297.HasMarker( (OperandVar299)); //IsContext = False IsNew = False
					OperandVar301 = prop300;
					if(ifResult298 = !(OperandVar301))
					{
						applicable = true;
						OperandVar302 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar302);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar303 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar303 != null) EntVar303.ComponentAdded();
			
			{
				Markers subContext304 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext304 ContextSwitchInterpreter
				if(subContext304 != null)
				{
					System.String OperandVar305 = default(System.String); //IsContext = False IsNew = False
					OperandVar305 = "faction_is_a_state";
					subContext304.SetMarker(( (OperandVar305)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar312 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable306 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable306 != null)
			{
				System.Boolean ifResult307; //IsContext = False IsNew = False
				System.Boolean OperandVar311 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar309 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable308 = ((Named)StoredVariable306.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable308 != null)
				{
					OperandVar309 = StoredVariable308;
				}
				System.Boolean prop310 = External.Has( (OperandVar309)); //IsContext = False IsNew = False
				OperandVar311 = prop310;
				if(ifResult307 = !(OperandVar311))
				{
					applicable = true;
					OperandVar312 = applicable;
				}
			}
			return (System.Boolean) (OperandVar312);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar313 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar313 ContextSwitchInterpreter
				if(ContextVar313 != null)
				{
					
					
					System.String OperandVar316 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar314 = default(System.String); //IsContext = False IsNew = False
					OperandVar314 = "country_name";
					System.String prop315 = External.RandomName( (OperandVar314)); //IsContext = False IsNew = False
					if(prop315 != null)
					{
						OperandVar316 = prop315;
					}
					ContextVar313.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar316)).ToString());
				}
			}
			Entity EntVar317 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar317 != null) EntVar317.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar327 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable318 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable318 != null)
			{
				TaleNode StoredVariable319 = ((TaleNode)StoredVariable318.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable319 != null)
				{
					System.Boolean ifResult320; //IsContext = False IsNew = False
					
					System.Boolean OperandVar324 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar322 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable318 != null)
					{
						UnityEngine.GameObject prop321 = StoredVariable318.Head; //IsContext = False IsNew = False
						if(prop321 != null)
						{
							OperandVar322 = prop321;
						}
					}
					System.Boolean prop323 = External.Has( (OperandVar322)); //IsContext = False IsNew = False
					OperandVar324 = prop323;
					
					System.Boolean OperandVar326 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop325 = StoredVariable319.IsActive; //IsContext = False IsNew = False
					OperandVar326 = prop325;
					if(ifResult320 = ( (!(OperandVar324))) && ( ( (OperandVar326))))
					{
						applicable = true;
						OperandVar327 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar327);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.state_node subContext328 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext328 ContextSwitchInterpreter
				if(subContext328 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state329 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext330 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext331 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext332 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext333 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext333 ContextSwitchInterpreter
							if(AddContext333 != null)
							{
								UnityEngine.GameObject OperandVar334 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar334 = root;
								AddContext333.State = (UnityEngine.GameObject)( (OperandVar334));
							}
						}
						Entity AddContext335 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Entity AddContext335 ContextSwitchInterpreter
							if(AddContext335 != null)
							{
								GODelegate Lambda336 = (UnityEngine.GameObject entity) => 
								{
									
									UnityEngine.GameObject OperandVar337 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar337 = head_of_state;
									subContext328.PastHeads.Add( (OperandVar337));
									
									{
										UnityEngine.GameObject subContext338 = root; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext338 ContextPropertySwitchInterpreter
										if(subContext338 != null)
										{
											
											{
												//ContextStatement Blackboards.state_node subContext328 ContextSwitchInterpreter
												if(subContext328 != null)
												{
													UnityEngine.GameObject OperandVar340 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
													UnityEngine.GameObject prop339 = External.NoOne(); //IsContext = False IsNew = False
													if(prop339 != null)
													{
														OperandVar340 = prop339;
													}
													subContext328.Head = (UnityEngine.GameObject)( (OperandVar340));
												}
											}
										}
									}
								};
								AddContext335.OnDestruction(Lambda336);
							}
						}
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext341 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext341 ContextPropertySwitchInterpreter
						if(subContext341 != null)
						{
							
							{
								TaleNode subContext342 = (TaleNode)subContext341.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext342 ContextSwitchInterpreter
								if(subContext342 != null)
								{
									
									subContext342.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar343 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar343 = head_of_state;
					subContext328.Head = (UnityEngine.GameObject)( (OperandVar343));
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar350 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable344 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable344 != null)
			{
				System.Boolean ifResult345; //IsContext = False IsNew = False
				System.Boolean OperandVar349 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar347 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable346 = ((Named)StoredVariable344.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable346 != null)
				{
					OperandVar347 = StoredVariable346;
				}
				System.Boolean prop348 = External.Has( (OperandVar347)); //IsContext = False IsNew = False
				OperandVar349 = prop348;
				if(ifResult345 = !(OperandVar349))
				{
					applicable = true;
					OperandVar350 = applicable;
				}
			}
			return (System.Boolean) (OperandVar350);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar351 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar351 ContextSwitchInterpreter
				if(ContextVar351 != null)
				{
					System.String OperandVar352 = default(System.String); //IsContext = False IsNew = False
					OperandVar352 = "main_name";
					
					System.String OperandVar355 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar353 = default(System.String); //IsContext = False IsNew = False
					OperandVar353 = "human_name";
					System.String prop354 = External.RandomName( (OperandVar353)); //IsContext = False IsNew = False
					if(prop354 != null)
					{
						OperandVar355 = prop354;
					}
					ContextVar351.Set(( (OperandVar352)).ToString(),(System.Single)( (0f)),( (OperandVar355)).ToString());
				}
			}
			Entity EntVar356 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar356 != null) EntVar356.ComponentAdded();
		}
        }
    }
}
